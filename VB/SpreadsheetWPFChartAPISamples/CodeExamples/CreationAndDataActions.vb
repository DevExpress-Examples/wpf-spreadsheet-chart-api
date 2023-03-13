Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module CreationAndDataActions

        Private Sub CreateChartFromRange(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#CreateChartFromRange"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a pie chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Pie3D, worksheet("B2:C7"))
            chart.TopLeftCell = worksheet.Cells("E2")
            chart.BottomRightCell = worksheet.Cells("K15")
            ' Set the chart style.
            chart.Style = DevExpress.Spreadsheet.Charts.ChartStyle.ColorGradient
'#End Region  ' #CreateChartFromRange
        End Sub

        Private Sub CreateChartAndSelectData(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#CreateChartAndSelectData"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chartRowData As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnStacked)
            chartRowData.TopLeftCell = worksheet.Cells("E3")
            chartRowData.BottomRightCell = worksheet.Cells("J12")
            ' Select chart data.
            chartRowData.SelectData(worksheet("B3:C8"))
'#End Region  ' #CreateChartAndSelectData
        End Sub

        Private Sub CreateChartAndSelectDataDirection(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#CreateChartAndSelectDataDirection"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chartRowData As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered)
            chartRowData.TopLeftCell = worksheet.Cells("D3")
            chartRowData.BottomRightCell = worksheet.Cells("I14")
            ' Select chart data by rows.
            chartRowData.SelectData(worksheet("B2:F6"), DevExpress.Spreadsheet.Charts.ChartDataDirection.Row)
            ' Create a chart and specify its location.
            Dim chartColumnData As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered)
            chartColumnData.TopLeftCell = worksheet.Cells("K3")
            chartColumnData.BottomRightCell = worksheet.Cells("N14")
            ' Select chart data by columns.
            chartColumnData.SelectData(worksheet("B2:F6"), DevExpress.Spreadsheet.Charts.ChartDataDirection.Column)
'#End Region  ' #CreateChartAndSelectDataDirection
        End Sub

        Private Sub CreateChartWithComplexRange(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#CreateChartWithComplexRange"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Add chart series using worksheet ranges as the data sources.
            chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
            chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))
'#End Region  ' #CreateChartWithComplexRange
        End Sub

        Private Sub CreateChartWithLiteralData(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#CreateChartWithLiteralData"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets(0)
            workbook.Worksheets.ActiveWorksheet = worksheet
            worksheet.Columns(CInt((0))).WidthInCharacters = 2.0
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("B2")
            chart.BottomRightCell = worksheet.Cells("H15")
            ' Add a series bound to a set of literal data.
            Dim series_of_literal As DevExpress.Spreadsheet.Charts.Series = chart.Series.Add(New DevExpress.Spreadsheet.CellValue() {"Jan", "Feb", "Mar", "Apr", "May", "Jun"}, New DevExpress.Spreadsheet.CellValue() {50, 100, 30, 104, 87, 150})
'#End Region  ' #CreateChartWithLiteralData
        End Sub

        Private Sub ChangeDataReference(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ChangeDataReference"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Add series using a worksheet range as the data source.
            chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
            chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))
            ' Change the data range for the series values.
            chart.Series(CInt((1))).Values = DevExpress.Spreadsheet.Charts.ChartData.FromRange(worksheet("E3:E6"))
            ' Specify the cell that is the source for the series name.
            chart.Series(CInt((1))).SeriesName.SetReference(worksheet("E2"))
'#End Region  ' #ChangeDataReference
        End Sub
    End Module
End Namespace
