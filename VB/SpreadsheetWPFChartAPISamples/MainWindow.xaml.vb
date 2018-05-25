Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Grid
Imports SpreadsheetChartAPISamples
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace SpreadsheetWPFChartAPISamples
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Private codeEditor As ExampleCodeEditor
        Private evaluator As ExampleEvaluatorByTimer
        Private richEditControlVBLoaded As Boolean = False
        Private richEditControlCsLoaded As Boolean = False
        Private defaultCulture As New CultureInfo("en-US")

        Public Sub New()
            InitializeComponent()
            Dim examplePath As String = "CodeExamples"
            Dim examplesCS As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
            Dim examplesVB As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB)
            DisableTabs(examplesCS.Count, examplesVB.Count)
            Dim examples As List(Of CodeExampleGroup) = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)
            ShowExamplesInTreeList(treeList1, examples)

            AddHandler richEditControlCS.Loaded, AddressOf richEditControlCS_Loaded
            AddHandler richEditControlVB.Loaded, AddressOf richEditControlVB_Loaded
            CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("SpreadsheetWPFChartAPISamples")
            Me.evaluator = New SpreadsheetExampleEvaluatorByTimer()

            AddHandler Me.evaluator.QueryEvaluate, AddressOf OnExampleEvaluatorQueryEvaluate
            AddHandler Me.evaluator.OnBeforeCompile, AddressOf evaluator_OnBeforeCompile
            AddHandler Me.evaluator.OnAfterCompile, AddressOf evaluator_OnAfterCompile
        End Sub

        Private Sub evaluator_OnAfterCompile(ByVal sender As Object, ByVal args As OnAfterCompileEventArgs)
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            For Each sheet As Worksheet In workbook.Worksheets
                sheet.PrintOptions.PrintGridlines = True
            Next sheet

            Dim firstSheet As Worksheet = workbook.Worksheets(0)
            Dim usedRange As Range = firstSheet.GetUsedRange()
            firstSheet.SelectedCell = usedRange(usedRange.RowCount * usedRange.ColumnCount - 1).Offset(1, 1)

            If codeEditor IsNot Nothing Then
                codeEditor.AfterCompile(args.Result)
            End If
            spreadsheetControl1.EndUpdate()
        End Sub

        Private Sub evaluator_OnBeforeCompile(ByVal sender As Object, ByVal args As EventArgs)
            spreadsheetControl1.BeginUpdate()
            If codeEditor IsNot Nothing Then
                codeEditor.BeforeCompile()
            End If

            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.Options.Culture = defaultCulture
            Dim loaded As Boolean = workbook.LoadDocument("Document.xlsx")
            System.Diagnostics.Debug.Assert(loaded)
        End Sub

        Private Sub richEditControlCS_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If richEditControlVBLoaded AndAlso Not richEditControlCsLoaded Then
                CreateCodeEditor()
            End If
            richEditControlCsLoaded = True
        End Sub

        Private Sub richEditControlVB_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If richEditControlCsLoaded AndAlso Not richEditControlVBLoaded Then
                CreateCodeEditor()
            End If
            richEditControlVBLoaded = True
        End Sub

        Private Sub DisableTabs(ByVal examplesCSCount As Integer, ByVal examplesVBCount As Integer)
            If examplesCSCount = 0 Then
                tabControl.GetTabItem(CInt(ExampleLanguage.Csharp)).IsEnabled = False
            End If
            If examplesVBCount = 0 Then
                tabControl.GetTabItem(CInt(ExampleLanguage.VB)).IsEnabled = False
            End If
        End Sub

        Private Sub CreateCodeEditor()
            System.Diagnostics.Debug.Assert(codeEditor Is Nothing)

            richEditControlCS.Tag = "Cs"
            richEditControlVB.Tag = "Vb"
            Me.codeEditor = New ExampleCodeEditor(richEditControlCS, richEditControlVB)
            Me.codeEditor.CurrentExampleLanguage = CurrentExampleLanguage

            ShowFirstExample()
        End Sub

        Private Sub ShowExamplesInTreeList(ByVal treeList1 As TreeListControl, ByVal examples As List(Of CodeExampleGroup))
            treeList1.ItemsSource = examples
        End Sub


        Private Sub ShowFirstExample()
            treeList1.View.ExpandAllNodes()

            If treeList1.View.Nodes.Count > 0 Then
                treeList1.View.FocusedNode = treeList1.View.Nodes(0).Nodes.First()
            End If
        End Sub

        Private Property CurrentExampleLanguage() As ExampleLanguage
            Get
                Return CType(tabControl.SelectedIndex, ExampleLanguage)
            End Get
            Set(ByVal value As ExampleLanguage)
                If codeEditor IsNot Nothing Then
                    Me.codeEditor.CurrentExampleLanguage = value
                End If
                tabControl.SelectedIndex = If(value = ExampleLanguage.Csharp, 0, 1)
            End Set
        End Property
        Private Sub OnNewExampleSelected(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            Dim newExample As CodeExample = TryCast(e.NewItem, CodeExample)
            Dim oldExample As CodeExample = TryCast(e.OldItem, CodeExample)

            If newExample Is Nothing Then
                Return
            End If

            If codeEditor Is Nothing Then
                Return
            End If

            Dim exampleCode As String = codeEditor.ShowExample(oldExample, newExample)
            codeExampleNameLbl.Content = CodeExampleDemoUtils.ConvertStringToMoreHumanReadableForm(newExample.RegionName) & " example"

            Dim args As New CodeEvaluationEventArgs()
            InitializeCodeEvaluationEventArgs(args)
            evaluator.ForceCompile(args)
        End Sub
        Private Sub InitializeCodeEvaluationEventArgs(ByVal e As CodeEvaluationEventArgs)
            e.Result = True
            If codeEditor Is Nothing Then
                Return
            End If

            e.Code = codeEditor.CurrentCodeEditor.Text
            e.Language = CurrentExampleLanguage
            e.EvaluationParameter = spreadsheetControl1.Document
        End Sub
        Private Sub OnExampleEvaluatorQueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
            e.Result = False
            If (codeEditor IsNot Nothing) AndAlso codeEditor.RichEditTextChanged Then
                Dim span As TimeSpan = Date.Now.Subtract(codeEditor.LastExampleCodeModifiedTime)

                If span < TimeSpan.FromMilliseconds(1000) Then
                    codeEditor.ResetLastExampleModifiedTime()
                    Return
                End If
                InitializeCodeEvaluationEventArgs(e)
            End If
        End Sub

        Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs)
            Dim value As ExampleLanguage = CType(e.NewSelectedIndex, ExampleLanguage)

            If Me.codeEditor IsNot Nothing Then
                Me.codeEditor.CurrentExampleLanguage = value
            End If
        End Sub

        Private Sub view_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.TreeList.TreeListCustomColumnDisplayTextEventArgs)

            If e.Node.HasChildren AndAlso TypeOf e.Node.Content Is CodeExampleGroup Then
                e.DisplayText = (TryCast(e.Node.Content, CodeExampleGroup)).Name
            End If
        End Sub
    End Class
End Namespace
