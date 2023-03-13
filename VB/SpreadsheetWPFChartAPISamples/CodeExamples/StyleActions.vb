Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module StyleActions

        Private Sub SetChartStyle(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SetChartStyle"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Set the chart style.
            chart.Style = DevExpress.Spreadsheet.Charts.ChartStyle.Accent1Dark
'#End Region  ' #SetChartStyle
        End Sub

        Private Sub CustomSeriesColor(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#CustomSeriesColor"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Change the series colors.
            chart.Series(CInt((0))).Fill.SetSolidFill(System.Drawing.Color.FromArgb(&H66, &HfF, &H66))
            chart.Series(CInt((1))).Fill.SetSolidFill(System.Drawing.Color.FromArgb(&HfF, &HfF, &H33))
'#End Region  ' #CustomSeriesColor
        End Sub

        Private Sub Transparency(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#Transparency"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Line, worksheet("B3:D8"))
            chart.TopLeftCell = worksheet.Cells("F3")
            chart.BottomRightCell = worksheet.Cells("L14")
            ' Customize the chart area and the plot area appearance.
            chart.Fill.SetNoFill()
            chart.Outline.SetSolidFill(System.Drawing.Color.FromArgb(&H99, &H99, &H99))
            chart.PlotArea.Fill.SetSolidFill(System.Drawing.Color.FromArgb(&H22, &H99, &H99, &H99))
            ' Specify the position of the legend.
            chart.Legend.Position = DevExpress.Spreadsheet.Charts.LegendPosition.Top
            ' Use a secondary axis.
            chart.Series(CInt((1))).AxisGroup = DevExpress.Spreadsheet.Charts.AxisGroup.Secondary
            ' Customize the axis scale and appearance.
            Dim axis As DevExpress.Spreadsheet.Charts.Axis = chart.PrimaryAxes(0)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = DevExpress.Spreadsheet.Charts.AxisTickMarks.None
            axis = chart.PrimaryAxes(1)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = DevExpress.Spreadsheet.Charts.AxisTickMarks.None
            axis.MajorGridlines.Visible = False
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Max = 1400
            axis.Scaling.Min = 0
            axis = chart.SecondaryAxes(1)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = DevExpress.Spreadsheet.Charts.AxisTickMarks.None
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Max = 390
            axis.Scaling.Min = 270
'#End Region  ' #Transparency
        End Sub
    End Module
End Namespace
