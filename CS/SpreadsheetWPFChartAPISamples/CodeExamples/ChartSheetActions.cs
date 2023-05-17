using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;

namespace SpreadsheetChartAPIActions
{
    public static class ChartSheetActions
    {
        static void CreateChartSheet(IWorkbook workbook)
        {
            #region #CreateChartSheet
            Worksheet worksheet = workbook.Worksheets["chartTask1"];

            // Create a chart sheet containing a pie chart.
            ChartSheet chartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet["B2:C7"]);

            workbook.ChartSheets.ActiveChartSheet = chartSheet;
            #endregion #CreateChartSheet
        }

        static void InsertChartSheets(IWorkbook workbook)
        {
            #region #InsertChartSheets
            Worksheet worksheet = workbook.Worksheets["chartTask1"];

            // Add a chart sheet to the workbook.
            workbook.ChartSheets.Add(ChartType.Pie, worksheet["B2:C7"]);

            // Insert a new chart sheet at the specified position in the chart sheet collection.
            workbook.ChartSheets.Insert(0, ChartType.ColumnClustered, worksheet["B2:C7"]);

            // Add a new chart sheet to the end of the collection.
            ChartSheet chartSheet = workbook.ChartSheets.Insert(2, ChartType.BarClustered);
            // Select chart data.
            chartSheet.Chart.SelectData(worksheet["B2:C7"]);
            #endregion #InsertChartSheets
        }

        static void SpecifyChartSettings(IWorkbook workbook)
        {
            #region #SpecifyChartSettings
            Worksheet worksheet = workbook.Worksheets["chartTask2"];

            // Create an empty chart sheet of the specified type.
            ChartSheet chartSheet = workbook.ChartSheets.Add(ChartType.BarFullStacked);

            // Access a chart on the chart sheet.
            ChartObject chart = chartSheet.Chart;
            // Select chart data.
            chart.SelectData(worksheet["B3:C8"], ChartDataDirection.Row);

            // Display the chart title.
            chart.Title.Visible = true;
            chart.Title.SetReference(worksheet["B1"]);

            // Change the legend position.
            chart.Legend.Position = LegendPosition.Bottom;

            // Hide the category axis.
            chart.PrimaryAxes[0].Visible = false;

            // Set the value axis' major unit.
            chart.PrimaryAxes[1].MajorUnit = 0.2;

            workbook.ChartSheets.ActiveChartSheet = chartSheet;
            #endregion #SpecifyChartSettings
        }

        static void RemoveChartSheet(IWorkbook workbook)
        {
            #region #RemoveChartSheet
            Worksheet worksheet = workbook.Worksheets["chartTask1"];

            // Create the first chart sheet.
            workbook.ChartSheets.Add();

            // Create the second chart sheet.
            workbook.ChartSheets.Add(ChartType.Pie, worksheet["B2:C7"]);

            // Remove the first chart sheet.
            workbook.ChartSheets.RemoveAt(0);
            #endregion #RemoveChartSheet
        }

        static void MoveToChartSheet(IWorkbook workbook)
        {
            #region #MoveToChartSheet
            Worksheet worksheet = workbook.Worksheets["chartTask1"];

            // Create an embedded chart on the worksheet.
            Chart chart = worksheet.Charts.Add(ChartType.Pie, worksheet["B2:C7"]);
            chart.TopLeftCell = worksheet.Cells["E2"];
            chart.BottomRightCell = worksheet.Cells["K15"];

            // Move the chart to a chart sheet.
            ChartSheet chartSheet = chart.MoveToNewChartSheet("Chart");

            workbook.ChartSheets.ActiveChartSheet = chartSheet;
            #endregion #MoveToChartSheet
        }

        static void MoveToWorksheet(IWorkbook workbook)
        {
            #region #MoveToWorksheet
            Worksheet worksheet = workbook.Worksheets["chartTask1"];

            // Create a chart sheet containing a pie chart.
            ChartSheet chartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet["B2:C7"]);

            // Move the chart to the worksheet with chart data.
            Chart embeddedChart = chartSheet.Chart.MoveToWorksheet(worksheet);
            // Adjust the chart location.
            embeddedChart.TopLeftCell = worksheet.Cells["E2"];
            embeddedChart.BottomRightCell = worksheet.Cells["K15"];

            workbook.Worksheets.ActiveWorksheet = worksheet;
            #endregion #MoveToWorksheet
        }

        static void ProtectChartSheet(IWorkbook workbook)
        {
            #region #ProtectChartSheet
            Worksheet worksheet = workbook.Worksheets["chartTask1"];

            // Create a chart sheet containing a pie chart.
            ChartSheet chartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet["B2:C7"]);

            // Protect the chart sheet. Prevent end-users from making changes to chart elements.
            if (!chartSheet.IsProtected)
                chartSheet.Protect("password", ChartSheetProtection.Default);

            workbook.ChartSheets.ActiveChartSheet = chartSheet;
            #endregion #ProtectChartSheet
        }

        static void SpecifyPrintOptions(IWorkbook workbook)
        {
            #region #SpecifyPrintOptions
            Worksheet worksheet = workbook.Worksheets["chartTask1"];
            workbook.Unit = DevExpress.Office.DocumentUnit.Inch;

            // Create a chart sheet containing a pie chart.
            ChartSheet chartSheet = workbook.ChartSheets.Add(ChartType.Pie, worksheet["B2:C7"]);

            // Specify print settings.
            chartSheet.ActiveView.Orientation = PageOrientation.Landscape;
            chartSheet.ActiveView.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Letter;

            // Specify page margins.
            Margins pageMargins = chartSheet.ActiveView.Margins;
            pageMargins.Left = 0.7F;
            pageMargins.Top = 0.75F;
            pageMargins.Right = 0.7F;
            pageMargins.Bottom = 0.75F;

            workbook.ChartSheets.ActiveChartSheet = chartSheet;
            #endregion #SpecifyPrintOptions
        }
    }
}
