Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions
    Public NotInheritable Class SeriesActions

        Private Sub New()
        End Sub

        Private Shared Sub RemoveSeries(ByVal workbook As IWorkbook)
'            #Region "#RemoveSeries"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:E6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Remove the series.
            chart.Series.RemoveAt(1)

'            #End Region ' #RemoveSeries
        End Sub

        Private Shared Sub ChangeSeriesOrder(ByVal workbook As IWorkbook)
'            #Region "#ChangeSeriesOrder"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Change the series order.
            chart.Series(1).BringForward()

'            #End Region ' #ChangeSeriesOrder
        End Sub

        Private Shared Sub UseSecondaryAxes(ByVal workbook As IWorkbook)
'            #Region "#UseSecondaryAxes"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")

            ' Use the secondary axis.
            chart.Series(1).AxisGroup = AxisGroup.Secondary

            ' Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Top

'            #End Region ' #UseSecondaryAxes
        End Sub

        Private Shared Sub ChangeSeriesType(ByVal workbook As IWorkbook)
'            #Region "#ChangeSeriesType"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")

            ' Change the type of the second series.
            chart.Series(1).ChangeType(ChartType.ColumnClustered)

            ' Use the secondary axis.
            chart.Series(1).AxisGroup = AxisGroup.Secondary

            ' Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Top

'            #End Region ' #ChangeSeriesType
        End Sub
        Private Shared Sub ChangeSeriesArguments(ByVal workbook As IWorkbook)
'            #Region "#ChangeSeriesArgumentsAndValues"
            Dim worksheet As Worksheet = workbook.Worksheets("Sheet1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            workbook.BeginUpdate()

            ' Create a chart.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet(0,0))
            ' Specify arguments.
            chart.Series(0).Arguments = New CellValue() {1,2,3}
            ' Specify values.
            chart.Series(0).Values = New CellValue() { 30, 20, 10 }

            workbook.EndUpdate()
'            #End Region ' #ChangeSeriesArgumentsAndValues
        End Sub
    End Class
End Namespace
