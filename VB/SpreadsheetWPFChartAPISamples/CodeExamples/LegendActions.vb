Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetChartAPIActions

    Public Module LegendActions

        Private Sub HideLegend(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#HideLegend"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:F6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Hide the legend.
            chart.Legend.Visible = False
'#End Region  ' #HideLegend
        End Sub

        Private Sub SetLegendPosition(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#SetLegendPosition"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:F6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Specify the position of the legend.
            chart.Legend.Position = DevExpress.Spreadsheet.Charts.LegendPosition.Bottom
'#End Region  ' #SetLegendPosition
        End Sub

        Private Sub ExcludeLegendEntry(ByVal workbook As DevExpress.Spreadsheet.IWorkbook)
'#Region "#ExcludeLegendEntry"
            Dim worksheet As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            ' Create a chart and specify its location.
            Dim chart As DevExpress.Spreadsheet.Charts.Chart = worksheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.ColumnClustered, worksheet("B2:F6"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            ' Exclude entries from the legend.
            chart.Legend.CustomEntries.Add(CInt((2))).Hidden = True
            chart.Legend.CustomEntries.Add(CInt((3))).Hidden = True
'#End Region  ' #ExcludeLegendEntry
        End Sub
    End Module
End Namespace
