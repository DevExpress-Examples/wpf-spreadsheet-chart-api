Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Reflection.Emit

Namespace SpreadsheetChartAPIActions
    Module TrendlineActions
        Private Sub Trendlines(ByVal workbook As IWorkbook)
            '            #Region "#Trendlines"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnStacked)
            chart.SelectData(worksheet("C2:F3"), ChartDataDirection.Row)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Show data labels.
            chart.Views(0).DataLabels.ShowValue = True

            ' Display a polynomial trendline.
            chart.Series(0).Trendlines.Add(ChartTrendlineType.Polynomial)
            '            #End Region ' #Trendlines
        End Sub

        Private Sub TrendlineCustomization(ByVal workbook As IWorkbook)
            '            #Region "#TrendlineCustomization"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ScatterMarkers)
            chart.SelectData(worksheet("C2:F3"), ChartDataDirection.Row)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Set the minimum and maximum values for the chart value axis.
            Dim axis As Axis = chart.PrimaryAxes(1)
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Min = 0.6
            axis.Scaling.Max = 1.0
            chart.PrimaryAxes(1).MajorGridlines.Visible = False

            ' Display a polynomial trendline.
            chart.Series(0).Trendlines.Add(ChartTrendlineType.Polynomial)

            ' Customize the trendline.
            Dim tline As Trendline = chart.Series(0).Trendlines(0)
            tline.DisplayEquation = True
            tline.CustomName = "Trend"
            tline.DisplayRSquare = True
            tline.Backward = 1
            tline.Forward = 2
            tline.Outline.SetSolidFill(Color.Red)
            '            #End Region ' #TrendlineCustomization
        End Sub

        Private Sub TrendlineLabel(ByVal workbook As IWorkbook)
            '            #Region "#TrendlineLabel"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet

            ' Create a chart and specify its location.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ScatterMarkers)
            chart.SelectData(worksheet("C2:F3"), ChartDataDirection.Row)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")

            ' Display a polynomial trendline.
            chart.Series(0).Trendlines.Add(ChartTrendlineType.Polynomial)

            ' Customize the trendline.
            Dim tline As Trendline = chart.Series(0).Trendlines(0)
            tline.DisplayEquation = True
            tline.CustomName = "Trend"
            tline.DisplayRSquare = True
            tline.Outline.SetSolidFill(Color.Red)

            ' Format the trend label.
            Dim tlabel As TrendlineLabel = tline.Label
            tlabel.Font.Name = "Tahoma"
            tlabel.Font.Italic = True
            tlabel.Fill.SetGradientFill(ShapeGradientType.Linear, Color.Orange, Color.White)
            ' Position the label in the right quarter of the chart area.
            tlabel.Layout.Left.SetPosition(LayoutMode.Edge, 0.75)
            '            #End Region ' #TrendlineLabel
        End Sub
    End Module
End Namespace
