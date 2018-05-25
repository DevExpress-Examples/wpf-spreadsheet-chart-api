Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions
    Public NotInheritable Class StyleActions

        Private Sub New()
        End Sub

        Private Shared Sub SetChartStyle(ByVal workbook As IWorkbook)
'            #Region "#SetChartStyle"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Set the chart style.
            chart.Style = ChartStyle.Accent1Dark

'            #End Region ' #SetChartStyle
        End Sub

        Private Shared Sub CustomSeriesColor(ByVal workbook As IWorkbook)
'            #Region "#CustomSeriesColor"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D4"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Change the series colors.
            chart.Series(0).Fill.SetSolidFill(Color.FromArgb(&H66, &Hff, &H66))
            chart.Series(1).Fill.SetSolidFill(Color.FromArgb(&Hff, &Hff, &H33))

'            #End Region ' #CustomSeriesColor
        End Sub

        Private Shared Sub Transparency(ByVal workbook As IWorkbook)
'            #Region "#Transparency"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask4")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Line, worksheet("B3:D8"))
            chart.TopLeftCell = worksheet.Cells("F3")
            chart.BottomRightCell = worksheet.Cells("L14")

            ' Customize the chart area and the plot area appearance.
            chart.Fill.SetNoFill()
            chart.Outline.SetSolidFill(Color.FromArgb(&H99, &H99, &H99))
            chart.PlotArea.Fill.SetSolidFill(Color.FromArgb(&H22, &H99, &H99, &H99))

            ' Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Top

            ' Use a secondary axis.
            chart.Series(1).AxisGroup = AxisGroup.Secondary

            ' Customize the axis scale and appearance.
            Dim axis As Axis = chart.PrimaryAxes(0)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = AxisTickMarks.None

            axis = chart.PrimaryAxes(1)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = AxisTickMarks.None
            axis.MajorGridlines.Visible = False
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Max = 1400
            axis.Scaling.Min = 0

            axis = chart.SecondaryAxes(1)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = AxisTickMarks.None
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Max = 390
            axis.Scaling.Min = 270

'            #End Region ' #Transparency
        End Sub
    End Class
End Namespace
