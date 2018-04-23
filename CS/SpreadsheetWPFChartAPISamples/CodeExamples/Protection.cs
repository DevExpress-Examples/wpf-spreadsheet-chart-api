using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetChartAPIActions
{
    public static class Protection
    {
        static void ProtectChart(IWorkbook workbook)
        {
            #region #ProtectChart
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Specify the chart style.
            chart.Style = ChartStyle.ColorDark;

            // Apply the chart protection.
            chart.Options.Protection = ChartProtection.All;

            #endregion #ProtectChart
        }

    }
}
