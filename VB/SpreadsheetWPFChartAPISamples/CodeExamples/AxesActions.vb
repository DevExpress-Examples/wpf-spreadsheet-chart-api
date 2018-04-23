Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions
    Public NotInheritable Class AxesActions

        Private Sub New()
        End Sub

        Private Shared Sub MinAndMaxValues(ByVal workbook As IWorkbook)
'            #Region "#MinAndMaxValues"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Set the minimum and maximum values for the chart value axis.
            Dim axis As Axis = chart.PrimaryAxes(1)
            axis.Scaling.AutoMax = False
            axis.Scaling.Max = 1
            axis.Scaling.AutoMin = False
            axis.Scaling.Min = 0

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #MinAndMaxValues
        End Sub

        Private Shared Sub MajorUnits(ByVal workbook As IWorkbook)
'            #Region "#MajorUnits"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarFullStacked)
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            ' Select chart data.
            chart.SelectData(worksheet("B4:C8"), ChartDataDirection.Row)

            ' Set the major unit of the value axis.
            chart.PrimaryAxes(1).MajorUnit = 0.2

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #MajorUnits
        End Sub

        Private Shared Sub MajorAndMinorGridlines(ByVal workbook As IWorkbook)
'            #Region "#MajorAndMinorGridlines"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")

            ' Display the major gridlines of the category axis.
            chart.PrimaryAxes(0).MajorGridlines.Visible = True
            ' Display the minor gridlines of the value axis.
            chart.PrimaryAxes(1).MinorGridlines.Visible = True

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #MajorAndMinorGridlines
        End Sub

        Private Shared Sub LabelsNumberFormat(ByVal workbook As IWorkbook)
'            #Region "#LabelsNumberFormat"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Format the axis labels.
            Dim axis As Axis = chart.PrimaryAxes(1)
            axis.NumberFormat.FormatCode = "0%"
            axis.NumberFormat.IsSourceLinked = False

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #LabelsNumberFormat
        End Sub

        Private Shared Sub HideTickMarks(ByVal workbook As IWorkbook)
'            #Region "#HideTickMarks"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Set the axis tick marks.
            Dim axis As Axis = chart.PrimaryAxes(0)
            axis.MajorTickMarks = AxisTickMarks.None
            axis = chart.PrimaryAxes(1)
            axis.MajorTickMarks = AxisTickMarks.None

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #HideTickMarks
        End Sub

        Private Shared Sub HideAxisLine(ByVal workbook As IWorkbook)
'            #Region "#HideAxisLine"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Hide the axis line.
            chart.PrimaryAxes(1).Outline.SetNoFill()

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #HideAxisLine
        End Sub

        Private Shared Sub Position(ByVal workbook As IWorkbook)
'            #Region "#AxisPosition"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Set the positon of the value axis.
            chart.PrimaryAxes(1).Position = AxisPosition.Right

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #AxisPosition
        End Sub

        Private Shared Sub Orientation(ByVal workbook As IWorkbook)
'            #Region "#AxisOrientation"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B3:C5"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Reverse the category axis.
            chart.PrimaryAxes(0).Scaling.Orientation = AxisOrientation.MaxMin

            ' Hide the legend.
            chart.Legend.Visible = False

'            #End Region ' #AxisOrientation
        End Sub

        Private Shared Sub LogScale(ByVal workbook As IWorkbook)
'            #Region "#LogScale"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Line, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")

            ' Set the logarithmic(Log10) type of scale.
            chart.PrimaryAxes(1).Scaling.LogScale = True
            chart.PrimaryAxes(1).Scaling.LogBase = 10

            ' Set the position of the legend on the chart.
            chart.Legend.Position = LegendPosition.Bottom

'            #End Region ' #LogScale
        End Sub
    End Class
End Namespace
