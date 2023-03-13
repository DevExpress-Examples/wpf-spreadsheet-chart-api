Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module ViewOptionsActions

        Private Sub ShowAutomaticMarkers(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ShowAutomaticMarkers"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Display markers using automatic style.
            chart.Series(CInt((0))).Marker.Symbol = DevExpress.Spreadsheet.Charts.MarkerStyle.Auto
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #ShowAutomaticMarkers
        End Sub

        Private Sub ShowCustomMarkers(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ShowCustomMarkers"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Display markers and specify the marker style.
            chart.Series(CInt((0))).Marker.Symbol = DevExpress.Spreadsheet.Charts.MarkerStyle.Circle
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #ShowCustomMarkers
        End Sub

        Private Sub SetMarkerSize(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SetMarkerSize"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Display markers and specify the marker style and size.
            chart.Series(CInt((0))).Marker.Symbol = DevExpress.Spreadsheet.Charts.MarkerStyle.Circle
            chart.Series(CInt((0))).Marker.Size = 15
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #SetMarkerSize
        End Sub

        Private Sub SmoothLines(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SmoothLines"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.LineMarker, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Turn on curve smoothing.
            chart.Series(CInt((0))).Smooth = True
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #SmoothLines
        End Sub

        Private Sub GapWidth(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#GapWidth"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Set the gap width between data series.
            chart.Views(CInt((0))).GapWidth = 33
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #GapWidth
        End Sub

        Private Sub VaryColorsByPoint(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#VaryColorsByPoint"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            ' Specify that each data point in the series has a different color.
            chart.Views(CInt((0))).VaryColors = True
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #VaryColorsByPoint
        End Sub
    End Module
End Namespace
