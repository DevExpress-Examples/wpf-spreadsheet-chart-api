Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts

Namespace SpreadsheetChartAPIActions
    Public NotInheritable Class ChartSheetActions

        Private Sub New()
        End Sub

        Private Shared Sub CreateChartSheet(ByVal workbook As IWorkbook)
'            #Region "#CreateChartSheet"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")

            ' Create a chart sheet containing a pie chart.
            Dim chartSheet As ChartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet("B2:C7"))

            workbook.ChartSheets.ActiveChartSheet = chartSheet
'            #End Region ' #CreateChartSheet
        End Sub

        Private Shared Sub InsertChartSheets(ByVal workbook As IWorkbook)
'            #Region "#InsertChartSheets"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")

            ' Add a chart sheet to the workbook.
            workbook.ChartSheets.Add(ChartType.Pie, worksheet("B2:C7"))

            ' Insert a new chart sheet at the specified position in the chart sheet collection.
            workbook.ChartSheets.Insert(0, ChartType.ColumnClustered, worksheet("B2:C7"))

            ' Add a new chart sheet to the end of the collection.
            Dim chartSheet As ChartSheet = workbook.ChartSheets.Insert(2, ChartType.BarClustered)
            ' Select chart data.
            chartSheet.Chart.SelectData(worksheet("B2:C7"))
'            #End Region ' #InsertChartSheets
        End Sub

        Private Shared Sub SpecifyChartSettings(ByVal workbook As IWorkbook)
'            #Region "#SpecifyChartSettings"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")

            ' Create an empty chart sheet of the specified type.
            Dim chartSheet As ChartSheet = workbook.ChartSheets.Add(ChartType.BarFullStacked)

            ' Access a chart on the chart sheet.
            Dim chart As ChartObject = chartSheet.Chart
            ' Select chart data.
            chart.SelectData(worksheet("B3:C8"), ChartDataDirection.Row)

            ' Display the chart title.
            chart.Title.Visible = True
            chart.Title.SetReference(worksheet("B1"))

            ' Change the legend position.
            chart.Legend.Position = LegendPosition.Bottom

            ' Hide the category axis.
            chart.PrimaryAxes(0).Visible = False

            ' Set the value axis' major unit.
            chart.PrimaryAxes(1).MajorUnit = 0.2

            workbook.ChartSheets.ActiveChartSheet = chartSheet
'            #End Region ' #SpecifyChartSettings
        End Sub

        Private Shared Sub RemoveChartSheet(ByVal workbook As IWorkbook)
'            #Region "#RemoveChartSheet"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")

            ' Create the first chart sheet.
            workbook.ChartSheets.Add()

            ' Create the second chart sheet.
            workbook.ChartSheets.Add(ChartType.Pie, worksheet("B2:C7"))

            ' Remove the first chart sheet.
            workbook.ChartSheets.RemoveAt(0)
'            #End Region ' #RemoveChartSheet
        End Sub

        Private Shared Sub MoveToChartSheet(ByVal workbook As IWorkbook)
'            #Region "#MoveToChartSheet"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")

            ' Create an embedded chart on the worksheet.
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Pie, worksheet("B2:C7"))
            chart.TopLeftCell = worksheet.Cells("E2")
            chart.BottomRightCell = worksheet.Cells("K15")

            ' Move the chart to a chart sheet.
            Dim chartSheet As ChartSheet = chart.MoveToNewChartSheet("Chart")

            workbook.ChartSheets.ActiveChartSheet = chartSheet
'            #End Region ' #MoveToChartSheet
        End Sub

        Private Shared Sub MoveToWorksheet(ByVal workbook As IWorkbook)
'            #Region "#MoveToWorksheet"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")

            ' Create a chart sheet containing a pie chart.
            Dim chartSheet As ChartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet("B2:C7"))

            ' Move the chart to the worksheet with chart data.
            Dim embeddedChart As Chart = chartSheet.Chart.MoveToWorksheet(worksheet)
            ' Adjust the chart location.
            embeddedChart.TopLeftCell = worksheet.Cells("E2")
            embeddedChart.BottomRightCell = worksheet.Cells("K15")

            workbook.Worksheets.ActiveWorksheet = worksheet
'            #End Region ' #MoveToWorksheet
        End Sub

        Private Shared Sub ProtectChartSheet(ByVal workbook As IWorkbook)
'            #Region "#ProtectChartSheet"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")

            ' Create a chart sheet containing a pie chart.
            Dim chartSheet As ChartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet("B2:C7"))

            ' Protect the chart sheet. Prevent end-users from making changes to chart elements.
            If Not chartSheet.IsProtected Then
                chartSheet.Protect("password", ChartSheetProtection.Default)
            End If

            workbook.ChartSheets.ActiveChartSheet = chartSheet
'            #End Region ' #ProtectChartSheet
        End Sub

        Private Shared Sub SpecifyPrintOptions(ByVal workbook As IWorkbook)
'            #Region "#SpecifyPrintOptions"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
            workbook.Unit = DevExpress.Office.DocumentUnit.Inch

            ' Create a chart sheet containing a pie chart.
            Dim chartSheet As ChartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet("B2:C7"))

            ' Specify print settings.
            chartSheet.ActiveView.Orientation = PageOrientation.Landscape
            chartSheet.ActiveView.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Letter

            ' Specify page margins.
            Dim pageMargins As Margins = chartSheet.ActiveView.Margins
            pageMargins.Left = 0.7F
            pageMargins.Top = 0.75F
            pageMargins.Right = 0.7F
            pageMargins.Bottom = 0.75F

            workbook.ChartSheets.ActiveChartSheet = chartSheet
'            #End Region ' #SpecifyPrintOptions
        End Sub
    End Class
End Namespace
