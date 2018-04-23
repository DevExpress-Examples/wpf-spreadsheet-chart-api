Imports Microsoft.VisualBasic
Imports Microsoft.CSharp
Imports System.CodeDom.Compiler

Namespace SpreadsheetChartAPISamples
	Public MustInherit Class SpreadsheetExampleCodeEvaluator
		Inherits ExampleCodeEvaluator


		Protected Overrides Function GetModuleAssembly() As String
			Return AssemblyInfo.SRAssemblySpreadsheetCore
		End Function
		Protected Overrides Function GetExampleClassName() As String
			Return "SpreadsheetCodeResultViewer.ExampleItem"
		End Function
	End Class
	#Region "SpreadsheetCSExampleCodeEvaluator"
	Partial Public Class SpreadsheetCSExampleCodeEvaluator
		Inherits SpreadsheetExampleCodeEvaluator

		Protected Overrides Function GetCodeDomProvider() As CodeDomProvider
			Return New CSharpCodeProvider()
		End Function

		Private Const codeStart_Renamed As String = "using System;" & Constants.vbCrLf & "using DevExpress.Spreadsheet;" & Constants.vbCrLf & "using DevExpress.Spreadsheet.Charts;" & Constants.vbCrLf & "using DevExpress.Spreadsheet.Drawings;" & Constants.vbCrLf & "using System.Drawing;" & Constants.vbCrLf & "using System.Windows.Forms;" & Constants.vbCrLf & "using DevExpress.XtraPrinting;" & Constants.vbCrLf & "using DevExpress.XtraPrinting.Control;" & Constants.vbCrLf & "using DevExpress.Utils;" & Constants.vbCrLf & "using System.IO;" & Constants.vbCrLf & "using System.Diagnostics;" & Constants.vbCrLf & "using System.Xml;" & Constants.vbCrLf & "using System.Data;" & Constants.vbCrLf & "using System.Collections.Generic;" & Constants.vbCrLf & "using System.Globalization;" & Constants.vbCrLf & "using Formatting = DevExpress.Spreadsheet.Formatting;" & Constants.vbCrLf & "namespace SpreadsheetCodeResultViewer { " & Constants.vbCrLf & "public class ExampleItem { " & Constants.vbCrLf & "        public static void Process(IWorkbook workbook) { " & Constants.vbCrLf & Constants.vbCrLf

		Private Const codeEnd_Renamed As String = "       " & Constants.vbCrLf & " }" & Constants.vbCrLf & "    }" & Constants.vbCrLf & "}" & Constants.vbCrLf
		Protected Overrides ReadOnly Property CodeStart() As String
			Get
				Return codeStart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property CodeEnd() As String
			Get
				Return codeEnd_Renamed
			End Get
		End Property
	End Class
	#End Region
	#Region "SpreadsheetVbExampleCodeEvaluator"
	Partial Public Class SpreadsheetVbExampleCodeEvaluator
		Inherits SpreadsheetExampleCodeEvaluator

		Protected Overrides Function GetCodeDomProvider() As CodeDomProvider
			Return New Microsoft.VisualBasic.VBCodeProvider()
		End Function
		Private Const codeStart_Renamed As String = "Imports Microsoft.VisualBasic" & Constants.vbCrLf & "Imports System" & Constants.vbCrLf & "Imports DevExpress.Spreadsheet" & Constants.vbCrLf & "Imports DevExpress.Spreadsheet.Charts" & Constants.vbCrLf & "Imports DevExpress.Spreadsheet.Drawings" & Constants.vbCrLf & "Imports System.Drawing" & Constants.vbCrLf & "Imports System.Windows.Forms" & Constants.vbCrLf & "Imports DevExpress.XtraPrinting" & Constants.vbCrLf & "Imports DevExpress.XtraPrinting.Control" & Constants.vbCrLf & "Imports DevExpress.Utils" & Constants.vbCrLf & "Imports System.IO" & Constants.vbCrLf & "Imports System.Diagnostics" & Constants.vbCrLf & "Imports System.Xml" & Constants.vbCrLf & "Imports System.Data" & Constants.vbCrLf & "Imports System.Collections.Generic" & Constants.vbCrLf & "Imports System.Globalization" & Constants.vbCrLf & "Imports Formatting = DevExpress.Spreadsheet.Formatting" & Constants.vbCrLf & "Namespace SpreadsheetCodeResultViewer" & Constants.vbCrLf & "	Public Class ExampleItem" & Constants.vbCrLf & "		Public Shared Sub Process(ByVal workbook As IWorkbook)" & Constants.vbCrLf & Constants.vbCrLf

		Private Const codeEnd_Renamed As String = Constants.vbCrLf & "		End Sub" & Constants.vbCrLf & "	End Class" & Constants.vbCrLf & "End Namespace" & Constants.vbCrLf

		Protected Overrides ReadOnly Property CodeStart() As String
			Get
				Return codeStart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property CodeEnd() As String
			Get
				Return codeEnd_Renamed
			End Get
		End Property
	End Class
	#End Region
End Namespace
