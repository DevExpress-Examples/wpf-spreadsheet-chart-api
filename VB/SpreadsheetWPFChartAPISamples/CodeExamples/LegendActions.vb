Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions
	Public NotInheritable Class LegendActions
		Private Sub New()
		End Sub
		Private Shared Sub HideLegend(ByVal workbook As IWorkbook)
'			#Region "#HideLegend"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:F6"))
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Hide the legend.
			chart.Legend.Visible = False

'			#End Region ' #HideLegend
		End Sub

		Private Shared Sub SetLegendPosition(ByVal workbook As IWorkbook)
'			#Region "#SetLegendPosition"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:F6"))
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Specify the position of the legend.
			chart.Legend.Position = LegendPosition.Bottom

'			#End Region ' #SetLegendPosition
		End Sub

		Private Shared Sub ExcludeLegendEntry(ByVal workbook As IWorkbook)
'			#Region "#ExcludeLegendEntry"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:F6"))
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Exclude entries from the legend.
			chart.Legend.CustomEntries.Add(2).Hidden = True
			chart.Legend.CustomEntries.Add(3).Hidden = True

'			#End Region ' #ExcludeLegendEntry
		End Sub
	End Class
End Namespace
