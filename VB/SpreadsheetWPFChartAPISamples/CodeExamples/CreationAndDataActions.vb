Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions
	Public NotInheritable Class CreationAndDataActions
		Private Sub New()
		End Sub
		Private Shared Sub CreateChartFromRange(ByVal workbook As IWorkbook)
'			#Region "#CreateChartFromRange"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a pie chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.Pie3D, worksheet("B2:C7"))
			chart.TopLeftCell = worksheet.Cells("E2")
			chart.BottomRightCell = worksheet.Cells("K15")

			' Set the chart style.
			chart.Style = ChartStyle.ColorGradient

'			#End Region ' #CreateChartFromRange
		End Sub

		Private Shared Sub CreateChartAndSelectData(ByVal workbook As IWorkbook)
'			#Region "#CreateChartAndSelectData"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chartRowData As Chart = worksheet.Charts.Add(ChartType.ColumnStacked)
			chartRowData.TopLeftCell = worksheet.Cells("E3")
			chartRowData.BottomRightCell = worksheet.Cells("J12")

			' Select chart data.
			chartRowData.SelectData(worksheet("B3:C8"))
'			#End Region ' #CreateChartAndSelectData
		End Sub

		Private Shared Sub CreateChartAndSelectDataDirection(ByVal workbook As IWorkbook)
'			#Region "#CreateChartAndSelectDataDirection"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chartRowData As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
			chartRowData.TopLeftCell = worksheet.Cells("D3")
			chartRowData.BottomRightCell = worksheet.Cells("I14")

			' Select chart data by rows.
			chartRowData.SelectData(worksheet("B2:F6"), ChartDataDirection.Row)

			' Create a chart and specify its location.
			Dim chartColumnData As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
			chartColumnData.TopLeftCell = worksheet.Cells("K3")
			chartColumnData.BottomRightCell = worksheet.Cells("N14")

			' Select chart data by columns.
			chartColumnData.SelectData(worksheet("B2:F6"), ChartDataDirection.Column)
'			#End Region ' #CreateChartAndSelectDataDirection
		End Sub

		Private Shared Sub CreateChartWithComplexRange(ByVal workbook As IWorkbook)
'			#Region "#CreateChartWithComplexRange"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Add chart series using worksheet ranges as the data sources.
			chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
			chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))

'			#End Region ' #CreateChartWithComplexRange
		End Sub

		Private Shared Sub CreateChartWithLiteralData(ByVal workbook As IWorkbook)
'			#Region "#CreateChartWithLiteralData"
			Dim worksheet As Worksheet = workbook.Worksheets(0)
			workbook.Worksheets.ActiveWorksheet = worksheet
			worksheet.Columns(0).WidthInCharacters = 2.0

			' Create a chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
			chart.TopLeftCell = worksheet.Cells("B2")
			chart.BottomRightCell = worksheet.Cells("H15")

			' Add a series bound to a set of literal data.
			Dim series_of_literal As Series = chart.Series.Add(New CellValue() { "Jan", "Feb", "Mar", "Apr", "May", "Jun" }, New CellValue() { 50, 100, 30, 104, 87, 150 })

'			#End Region ' #CreateChartWithLiteralData
		End Sub

		Private Shared Sub ChangeDataReference(ByVal workbook As IWorkbook)
'			#Region "#ChangeDataReference"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location.
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")
			' Add series using a worksheet range as the data source.
			chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
			chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))

			' Change the data range for the series values.
			chart.Series(1).Values = ChartData.FromRange(worksheet("E3:E6"))

			' Specify the cell that is the source for the series name.
			chart.Series(1).SeriesName.SetReference(worksheet("E2"))

'			#End Region ' #ChangeDataReference
		End Sub
	End Class
End Namespace
