Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Grid
Imports SpreadsheetChartAPISamples
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Windows
Imports System.Windows.Controls

Namespace SpreadsheetWPFChartAPISamples

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Private codeEditor As ExampleCodeEditor

        Private evaluator As ExampleEvaluatorByTimer

        Private richEditControlVBLoaded As Boolean = False

        Private richEditControlCsLoaded As Boolean = False

        Private defaultCulture As CultureInfo = New CultureInfo("en-US")

        Public Sub New()
            Me.InitializeComponent()
            Dim examplePath As String = "CodeExamples"
            Dim examplesCS As Dictionary(Of String, FileInfo) = GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
            Dim examplesVB As Dictionary(Of String, FileInfo) = GatherExamplesFromProject(examplePath, ExampleLanguage.VB)
            DisableTabs(examplesCS.Count, examplesVB.Count)
            Dim examples As List(Of CodeExampleGroup) = FindExamples(examplePath, examplesCS, examplesVB)
            Me.ShowExamplesInTreeList(Me.treeList1, examples)
            AddHandler Me.richEditControlCS.Loaded, AddressOf Me.richEditControlCS_Loaded
            AddHandler Me.richEditControlVB.Loaded, AddressOf Me.richEditControlVB_Loaded
            CurrentExampleLanguage = DetectExampleLanguage("SpreadsheetWPFChartAPISamples")
            evaluator = New SpreadsheetExampleEvaluatorByTimer()
            AddHandler evaluator.QueryEvaluate, AddressOf OnExampleEvaluatorQueryEvaluate
            AddHandler evaluator.OnBeforeCompile, AddressOf evaluator_OnBeforeCompile
            AddHandler evaluator.OnAfterCompile, AddressOf evaluator_OnAfterCompile
        End Sub

        Private Sub evaluator_OnAfterCompile(ByVal sender As Object, ByVal args As OnAfterCompileEventArgs)
            Dim workbook As IWorkbook = Me.spreadsheetControl1.Document
            For Each sheet As Worksheet In workbook.Worksheets
                sheet.PrintOptions.PrintGridlines = True
            Next

            Dim firstSheet As Worksheet = workbook.Worksheets(0)
            Dim usedRange As Range = firstSheet.GetUsedRange()
            firstSheet.SelectedCell = usedRange(usedRange.RowCount * usedRange.ColumnCount - 1).Offset(1, 1)
            If codeEditor IsNot Nothing Then codeEditor.AfterCompile(args.Result)
            Me.spreadsheetControl1.EndUpdate()
        End Sub

        Private Sub evaluator_OnBeforeCompile(ByVal sender As Object, ByVal args As EventArgs)
            Me.spreadsheetControl1.BeginUpdate()
            If codeEditor IsNot Nothing Then codeEditor.BeforeCompile()
            Dim workbook As IWorkbook = Me.spreadsheetControl1.Document
            workbook.Options.Culture = defaultCulture
            Dim loaded As Boolean = workbook.LoadDocument("Document.xlsx")
            System.Diagnostics.Debug.Assert(loaded)
        End Sub

        Private Sub richEditControlCS_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If richEditControlVBLoaded AndAlso Not richEditControlCsLoaded Then CreateCodeEditor()
            richEditControlCsLoaded = True
        End Sub

        Private Sub richEditControlVB_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If richEditControlCsLoaded AndAlso Not richEditControlVBLoaded Then CreateCodeEditor()
            richEditControlVBLoaded = True
        End Sub

        Private Sub DisableTabs(ByVal examplesCSCount As Integer, ByVal examplesVBCount As Integer)
            If examplesCSCount = 0 Then Me.tabControl.GetTabItem(CInt(ExampleLanguage.Csharp)).IsEnabled = False
            If examplesVBCount = 0 Then Me.tabControl.GetTabItem(CInt(ExampleLanguage.VB)).IsEnabled = False
        End Sub

        Private Sub CreateCodeEditor()
            System.Diagnostics.Debug.Assert(codeEditor Is Nothing)
            Me.richEditControlCS.Tag = "Cs"
            Me.richEditControlVB.Tag = "Vb"
            codeEditor = New ExampleCodeEditor(Me.richEditControlCS, Me.richEditControlVB)
            codeEditor.CurrentExampleLanguage = CurrentExampleLanguage
            ShowFirstExample()
        End Sub

        Private Sub ShowExamplesInTreeList(ByVal treeList1 As TreeListControl, ByVal examples As List(Of CodeExampleGroup))
            treeList1.ItemsSource = examples
        End Sub

        Private Sub ShowFirstExample()
            Me.treeList1.View.ExpandAllNodes()
            If Me.treeList1.View.Nodes.Count > 0 Then Me.treeList1.View.FocusedNode = Me.treeList1.View.Nodes(0).Nodes.First()
        End Sub

        Private Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return CType(Me.tabControl.SelectedIndex, ExampleLanguage)
            End Get

            Set(ByVal value As ExampleLanguage)
                If codeEditor IsNot Nothing Then codeEditor.CurrentExampleLanguage = value
                Me.tabControl.SelectedIndex = If(value = ExampleLanguage.Csharp, 0, 1)
            End Set
        End Property

        Private Sub OnNewExampleSelected(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            Dim newExample As CodeExample = TryCast(e.NewItem, CodeExample)
            Dim oldExample As CodeExample = TryCast(e.OldItem, CodeExample)
            If newExample Is Nothing Then Return
            If codeEditor Is Nothing Then Return
            Dim exampleCode As String = codeEditor.ShowExample(oldExample, newExample)
            Me.codeExampleNameLbl.Content = ConvertStringToMoreHumanReadableForm(newExample.RegionName) & " example"
            Dim args As CodeEvaluationEventArgs = New CodeEvaluationEventArgs()
            InitializeCodeEvaluationEventArgs(args)
            evaluator.ForceCompile(args)
        End Sub

        Private Sub InitializeCodeEvaluationEventArgs(ByVal e As CodeEvaluationEventArgs)
            e.Result = True
            If codeEditor Is Nothing Then Return
            e.Code = codeEditor.CurrentCodeEditor.Text
            e.Language = CurrentExampleLanguage
            e.EvaluationParameter = Me.spreadsheetControl1.Document
        End Sub

        Private Sub OnExampleEvaluatorQueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
            e.Result = False
            If codeEditor IsNot Nothing AndAlso codeEditor.RichEditTextChanged Then
                Dim span As TimeSpan = Date.Now - codeEditor.LastExampleCodeModifiedTime
                If span < TimeSpan.FromMilliseconds(1000) Then
                    codeEditor.ResetLastExampleModifiedTime()
                    Return
                End If

                InitializeCodeEvaluationEventArgs(e)
            End If
        End Sub

        Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs)
            Dim value As ExampleLanguage = CType(e.NewSelectedIndex, ExampleLanguage)
            If codeEditor IsNot Nothing Then codeEditor.CurrentExampleLanguage = value
        End Sub

        Private Sub view_CustomColumnDisplayText(ByVal sender As Object, ByVal e As TreeList.TreeListCustomColumnDisplayTextEventArgs)
            If e.Node.HasChildren AndAlso TypeOf e.Node.Content Is CodeExampleGroup Then
                e.DisplayText = TryCast(e.Node.Content, CodeExampleGroup).Name
            End If
        End Sub
    End Class
End Namespace
