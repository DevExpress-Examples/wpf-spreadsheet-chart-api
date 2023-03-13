Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module AxesActions

        Private Sub MinAndMaxValues(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#MinAndMaxValues"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Set the minimum and maximum values for the chart value axis.
            Dim axis As DevExpress.Spreadsheet.Charts.Axis = chart.PrimaryAxes(1)
            axis.Scaling.AutoMax = False
            axis.Scaling.Max = 1
            axis.Scaling.AutoMin = False
            axis.Scaling.Min = 0
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #MinAndMaxValues
        End Sub

        Private Sub MajorUnits(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#MajorUnits"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarFullStacked)
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Select chart data.
            chart.SelectData(worksheet("B4:C8"), DevExpress.Spreadsheet.Charts.ChartDataDirection.Row)
            ' Set the major unit of the value axis.
            chart.PrimaryAxes(CInt((1))).MajorUnit = 0.2
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #MajorUnits
        End Sub

        Private Sub MajorAndMinorGridlines(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#MajorAndMinorGridlines"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Display the major gridlines of the category axis.
            chart.PrimaryAxes(CInt((0))).MajorGridlines.Visible = True
            ' Display the minor gridlines of the value axis.
            chart.PrimaryAxes(CInt((1))).MinorGridlines.Visible = True
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #MajorAndMinorGridlines
        End Sub

        Private Sub LabelsNumberFormat(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#LabelsNumberFormat"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Format the axis labels.
            Dim axis As DevExpress.Spreadsheet.Charts.Axis = chart.PrimaryAxes(1)
            axis.NumberFormat.FormatCode = "0%"
            axis.NumberFormat.IsSourceLinked = False
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #LabelsNumberFormat
        End Sub

        Private Sub HideTickMarks(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#HideTickMarks"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Set the axis tick marks.
            Dim axis As DevExpress.Spreadsheet.Charts.Axis = chart.PrimaryAxes(0)
            axis.MajorTickMarks = DevExpress.Spreadsheet.Charts.AxisTickMarks.None
            axis = chart.PrimaryAxes(1)
            axis.MajorTickMarks = DevExpress.Spreadsheet.Charts.AxisTickMarks.None
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #HideTickMarks
        End Sub

        Private Sub HideAxisLine(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#HideAxisLine"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Hide the axis line.
            chart.PrimaryAxes(CInt((1))).Outline.SetNoFill()
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #HideAxisLine
        End Sub

        Private Sub Position(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#AxisPosition"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Set the positon of the value axis.
            chart.PrimaryAxes(CInt((1))).Position = DevExpress.Spreadsheet.Charts.AxisPosition.Right
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #AxisPosition
        End Sub

        Private Sub Orientation(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#AxisOrientation"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Reverse the category axis.
            chart.PrimaryAxes(CInt((0))).Scaling.Orientation = DevExpress.Spreadsheet.Charts.AxisOrientation.MaxMin
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #AxisOrientation
        End Sub

        Private Sub LogScale(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#LogScale"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Line, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Set the logarithmic(Log10) type of scale.
            chart.PrimaryAxes(CInt((1))).Scaling.LogScale = True
            chart.PrimaryAxes(CInt((1))).Scaling.LogBase = 10
            ' Set the position of the legend on the chart.
            chart.Legend.Position = DevExpress.Spreadsheet.Charts.LegendPosition.Bottom
'#End Region  ' #LogScale
        End Sub
    End Module
End Namespace
