Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions
    Public NotInheritable Class DataLabelsActions

        Private Sub New()
        End Sub

        Private Shared Sub ShowDataLabels(ByVal workbook As IWorkbook)
'            #Region "#ShowDataLabels"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Show data labels.
            chart.Views(0).DataLabels.ShowValue = True

'            #End Region ' #ShowDataLabels
        End Sub

        Private Shared Sub SetDataLabelsPosition(ByVal workbook As IWorkbook)
'            #Region "#SetDataLabelsPosition"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Display data labels and specify their position within the chart.
            chart.Views(0).DataLabels.ShowValue = True
            chart.Views(0).DataLabels.LabelPosition = DataLabelPosition.Center

'            #End Region ' #SetDataLabelsPosition
        End Sub

        Private Shared Sub DataLabelsNumberFormat(ByVal workbook As IWorkbook)
'            #Region "#DataLabelsNumberFormat"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Display data labels and specify their position within the chart.
            chart.Views(0).DataLabels.ShowValue = True
            chart.Views(0).DataLabels.LabelPosition = DataLabelPosition.Center

            ' Format data labels.
            chart.Views(0).DataLabels.NumberFormat.FormatCode = "0%"
            chart.Views(0).DataLabels.NumberFormat.IsSourceLinked = False

'            #End Region ' #DataLabelsNumberFormat
        End Sub

        Private Shared Sub DataLabelsPerSeries(ByVal workbook As IWorkbook)
'            #Region "#DataLabelsPerSeries"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Display data labels for the second series.
            chart.Series(1).CustomDataLabels.ShowValue = True
            chart.Series(1).UseCustomDataLabels = True

'            #End Region ' #DataLabelsPerSeries
        End Sub

        Private Shared Sub DataLabelsPerPoint(ByVal workbook As IWorkbook)
'            #Region "#DataLabelsPerPoint"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Display the data label for the last point of the second series.
            chart.Series(1).CustomDataLabels.Add(1).ShowValue = True
            chart.Series(1).UseCustomDataLabels = True

'            #End Region ' #DataLabelsPerPoint
        End Sub

        Private Shared Sub DataLabelsSeparator(ByVal workbook As IWorkbook)
            '            #Region "#DataLabelsSeparator"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Pie, worksheet("B2:C7"))
            chart.TopLeftCell = worksheet.Cells("E2")
            chart.BottomRightCell = worksheet.Cells("K15")

            ' Display the category name and percentage.
            Dim dataLabels As DataLabelOptions = chart.Views(0).DataLabels
            dataLabels.ShowCategoryName = True
            dataLabels.ShowPercent = True
            dataLabels.Separator = vbLf

            ' Set the chart style.
            chart.Style = ChartStyle.ColorGradient
            ' Hide the legend.
            chart.Legend.Visible = False
            ' Set the angle of the first pie-chart slice.
            chart.Views(0).FirstSliceAngle = 100

            '            #End Region ' #DataLabelsSeparator
        End Sub

        Private Shared Sub DataLabelsFromCells(ByVal workbook As IWorkbook)
            '            #Region "#DataLabelsFromCells"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")

            ' Specify the chart style
            chart.Style = ChartStyle.ColorGradient
            chart.Series(0).UseCustomDataLabels = True
            Dim customDataLabels = chart.Series(0).CustomDataLabels
            customDataLabels.SetReference("D3:D8")
            '            #End Region ' #DataLabelsFromCells
        End Sub
    End Class
End Namespace
