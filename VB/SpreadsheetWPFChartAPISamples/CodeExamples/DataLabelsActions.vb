Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module DataLabelsActions

        Private Sub ShowDataLabels(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ShowDataLabels"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Show data labels.
            chart.Views(CInt((0))).DataLabels.ShowValue = True
'#End Region  ' #ShowDataLabels
        End Sub

        Private Sub SetDataLabelsPosition(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SetDataLabelsPosition"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Display data labels and specify their position within the chart.
            chart.Views(CInt((0))).DataLabels.ShowValue = True
            chart.Views(CInt((0))).DataLabels.LabelPosition = DevExpress.Spreadsheet.Charts.DataLabelPosition.Center
'#End Region  ' #SetDataLabelsPosition
        End Sub

        Private Sub DataLabelsNumberFormat(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#DataLabelsNumberFormat"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Display data labels and specify their position within the chart.
            chart.Views(CInt((0))).DataLabels.ShowValue = True
            chart.Views(CInt((0))).DataLabels.LabelPosition = DevExpress.Spreadsheet.Charts.DataLabelPosition.Center
            ' Format data labels.
            chart.Views(CInt((0))).DataLabels.NumberFormat.FormatCode = "0%"
            chart.Views(CInt((0))).DataLabels.NumberFormat.IsSourceLinked = False
'#End Region  ' #DataLabelsNumberFormat
        End Sub

        Private Sub DataLabelsPerSeries(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#DataLabelsPerSeries"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Display data labels for the second series.
            chart.Series(CInt((1))).CustomDataLabels.ShowValue = True
            chart.Series(CInt((1))).UseCustomDataLabels = True
'#End Region  ' #DataLabelsPerSeries
        End Sub

        Private Sub DataLabelsPerPoint(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#DataLabelsPerPoint"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Display the data label for the last point of the second series.
            chart.Series(CInt((1))).CustomDataLabels.Add(CInt((1))).ShowValue = True
            chart.Series(CInt((1))).UseCustomDataLabels = True
'#End Region  ' #DataLabelsPerPoint
        End Sub

        Private Sub DataLabelsSeparator(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#DataLabelsSeparator"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Pie, worksheet("B2:C7"))
            chart.TopLeftCell = worksheet.Cells("E2")
            chart.BottomRightCell = worksheet.Cells("K15")
            ' Display the category name and percentage.
            Dim dataLabels As DevExpress.Spreadsheet.Charts.DataLabelOptions = chart.Views(CInt((0))).DataLabels
            dataLabels.ShowCategoryName = True
            dataLabels.ShowPercent = True
            dataLabels.Separator = Global.Microsoft.VisualBasic.Constants.vbLf
            ' Set the chart style.
            chart.Style = DevExpress.Spreadsheet.Charts.ChartStyle.ColorGradient
            ' Hide the legend.
            chart.Legend.Visible = False
            ' Set the angle of the first pie-chart slice.
            chart.Views(CInt((0))).FirstSliceAngle = 100
'#End Region  ' #DataLabelsSeparator
        End Sub
    End Module
End Namespace
