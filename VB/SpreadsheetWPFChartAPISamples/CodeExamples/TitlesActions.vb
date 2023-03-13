Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module TitlesActions

        Private Sub ShowChartTitle(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ShowChartTitle"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Display default chart title.
            chart.Title.Visible = True
            ' Display the chart legend. 
            chart.Legend.Visible = False
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
'#End Region  ' #ShowChartTitle
        End Sub

        Private Sub SetChartTitleText(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SetChartTitleText"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Display the chart title and specify the title text.
            chart.Title.Visible = True
            chart.Title.SetValue("Market share Q3'13")
            ' Hide the chart legend.
            chart.Legend.Visible = False
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
'#End Region  ' #SetChartTitleText
        End Sub

        Private Sub LinkChartTitleToCellRange(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#LinkChartTitleToCellRange"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Display the chart title and set the source cell for the title text.
            chart.Title.Visible = True
            chart.Title.SetReference(worksheet("B1"))
            ' Hide the legend.
            chart.Legend.Visible = False
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
'#End Region  ' #LinkChartTitleToCellRange
        End Sub

        Private Sub ShowAxisTitle(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ShowAxisTitle"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Show the axis title.
            chart.PrimaryAxes(CInt((1))).Title.Visible = True
            ' Hide the legend.
            chart.Legend.Visible = False
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
'#End Region  ' #ShowAxisTitle
        End Sub

        Private Sub SetAxisTitleText(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SetAxisTitleText"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Specify the axis title text.
            chart.PrimaryAxes(CInt((1))).Title.Visible = True
            chart.PrimaryAxes(CInt((1))).Title.SetValue("Shipment in millions of units")
            ' Hide the legend.
            chart.Legend.Visible = False
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
'#End Region  ' #SetAxisTitleText
        End Sub

        Private Sub LinkAxisTitleToCellRange(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#LinkAxisTitleToCellRange"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Bind the axis title text to a worksheet cell.
            chart.PrimaryAxes(CInt((1))).Title.Visible = True
            chart.PrimaryAxes(CInt((1))).Title.SetReference(worksheet("C3"))
            ' Hide the legend.
            chart.Legend.Visible = False
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
'#End Region  ' #LinkAxisTitleToCellRange
        End Sub
    End Module
End Namespace
