Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module SeriesActions

        Private Sub RemoveSeries(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#RemoveSeries"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:E6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Remove the series.
            chart.Series.RemoveAt(1)
'#End Region  ' #RemoveSeries
        End Sub

        Private Sub ChangeSeriesOrder(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ChangeSeriesOrder"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Change the series order.
            chart.Series(CInt((1))).BringForward()
'#End Region  ' #ChangeSeriesOrder
        End Sub

        Private Sub UseSecondaryAxes(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#UseSecondaryAxes"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.LineMarker, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Use the secondary axis.
            chart.Series(CInt((1))).AxisGroup = DevExpress.Spreadsheet.Charts.AxisGroup.Secondary
            ' Specify the position of the legend.
            chart.Legend.Position = DevExpress.Spreadsheet.Charts.LegendPosition.Top
'#End Region  ' #UseSecondaryAxes
        End Sub

        Private Sub ChangeSeriesType(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ChangeSeriesType"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.LineMarker, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Change the type of the second series.
            chart.Series(CInt((1))).ChangeType(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered)
            ' Use the secondary axis.
            chart.Series(CInt((1))).AxisGroup = DevExpress.Spreadsheet.Charts.AxisGroup.Secondary
            ' Specify the position of the legend.
            chart.Legend.Position = DevExpress.Spreadsheet.Charts.LegendPosition.Top
'#End Region  ' #ChangeSeriesType
        End Sub

        Private Sub ChangeSeriesArguments(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ChangeSeriesArgumentsAndValues"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("Sheet1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            workbook.BeginUpdate()
            ' Create a chart.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.LineMarker, worksheet(0, 0))
            ' Specify arguments.
            chart.Series(CInt((0))).Arguments = New DevExpress.Spreadsheet.CellValue() {1, 2, 3}
            ' Specify values.
            chart.Series(CInt((0))).Values = New DevExpress.Spreadsheet.CellValue() {30, 20, 10}
            workbook.EndUpdate()
'#End Region  ' #ChangeSeriesArgumentsAndValues
        End Sub
    End Module
End Namespace
