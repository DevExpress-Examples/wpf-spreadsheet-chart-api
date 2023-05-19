using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;

namespace SpreadsheetChartAPIActions
{
    public static class DataTableActions
    {
        static void ShowDataTables(IWorkbook workbook)
        {
            #region #ShowDataTable
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L14"];
            DataTableOptions dataTableOptions = chart.DataTable;
            dataTableOptions.Visible = true;
            dataTableOptions.ShowLegendKeys = false;

            #endregion #ShowDataTable
        }

        static void ChangeDataTableBorders(IWorkbook workbook) 
        {
            #region #ChangeDataTableBorders
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L14"];
            DataTableOptions dataTableOptions = chart.DataTable;
            dataTableOptions.Visible = true;
            dataTableOptions.ShowLegendKeys = false;

            dataTableOptions.ShowVerticalBorder = false;
            dataTableOptions.ShowHorizontalBorder = false;
            #endregion #ChangeDataTableBorders
        }

        static void ChangeDataTableFont(IWorkbook workbook)
        {
            #region #ChangeDataTableFont
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L14"];
            DataTableOptions dataTableOptions = chart.DataTable;
            dataTableOptions.Visible = true;
            dataTableOptions.ShowLegendKeys = false;

            dataTableOptions.Font.Name = "Helvetica";
            dataTableOptions.Font.Size = 12;
            #endregion #ChangeDataTableFont
        }

    }
}
