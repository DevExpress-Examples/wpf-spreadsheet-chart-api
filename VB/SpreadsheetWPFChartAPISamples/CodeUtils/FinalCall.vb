Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SpreadsheetChartAPISamples
	Public NotInheritable Class FinalCallHelper
		Private Sub New()
		End Sub
		Public Shared Function CheckModule(ByVal lang As ExampleLanguage, ByVal regionName As String) As String
			Dim modules As New List(Of String) (New String() {"Pie Of Pie Chart", "Custom Walls and Floor"})
			If modules.Contains(regionName) Then
				If lang = ExampleLanguage.Csharp Then
					Return finalCallCS
				End If
				If lang = ExampleLanguage.VB Then
					Return finalCallVB
				End If
			End If

			Return String.Empty
		End Function

			Private Const finalCallCS As String = "worksheet = workbook.Worksheets[""blankSheet""];" & Constants.vbCrLf & "workbook.Worksheets.ActiveWorksheet = worksheet;" & Constants.vbCrLf & "worksheet.Cells[""B2""].Value =" & """SpeadsheetControl does not visualize this sample correctly."" + Environment.NewLine +" & """However, property values are loaded and stored in supported formats,"" + Environment.NewLine +" & """so that you can modify them programmatically"" + Environment.NewLine +" & """and display the result in Microsoft Excel."";"

			Private Const finalCallVB As String = "worksheet = workbook.Worksheets(""blankSheet"")" & Constants.vbCrLf & "workbook.Worksheets.ActiveWorksheet = worksheet" & Constants.vbCrLf & "worksheet.Cells(""B2"").Value = " & """SpeadsheetControl does not visualize this sample correctly.""" & "& Constants.vbCrLf & ""However, property values are loaded and stored in supported formats,""" & "& Constants.vbCrLf & ""and you can modify them programmatically."""
	End Class

End Namespace
