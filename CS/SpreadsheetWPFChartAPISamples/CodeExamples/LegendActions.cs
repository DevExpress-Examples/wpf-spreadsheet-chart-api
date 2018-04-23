using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class LegendActions {
        static void HideLegend(IWorkbook workbook) {
            #region #HideLegend
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:F6"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #HideLegend
        }

        static void SetLegendPosition(IWorkbook workbook) {
            #region #SetLegendPosition
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:F6"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Bottom;

            #endregion #SetLegendPosition
        }

        static void ExcludeLegendEntry(IWorkbook workbook) {
            #region #ExcludeLegendEntry
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:F6"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Exclude entries from the legend.
            chart.Legend.CustomEntries.Add(2).Hidden = true;
            chart.Legend.CustomEntries.Add(3).Hidden = true;

            #endregion #ExcludeLegendEntry
        }
    }
}
