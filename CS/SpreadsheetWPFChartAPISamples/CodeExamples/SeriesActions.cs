using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class SeriesActions {
        static void RemoveSeries(IWorkbook workbook) {
            #region #RemoveSeries
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:E6"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Remove the series.
            chart.Series.RemoveAt(1);

            #endregion #RemoveSeries
        }

        static void ChangeSeriesOrder(IWorkbook workbook) {
            #region #ChangeSeriesOrder
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D6"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Change the series order.
            chart.Series[1].BringForward();

            #endregion #ChangeSeriesOrder
        }

        static void UseSecondaryAxes(IWorkbook workbook) {
            #region #UseSecondaryAxes
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet["B2:D8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Use the secondary axis.
            chart.Series[1].AxisGroup = AxisGroup.Secondary;

            // Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Top;

            #endregion #UseSecondaryAxes
        }

        static void ChangeSeriesType(IWorkbook workbook) {
            #region #ChangeSeriesType
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet["B2:D8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Change the type of the second series.
            chart.Series[1].ChangeType(ChartType.ColumnClustered);

            // Use the secondary axis.
            chart.Series[1].AxisGroup = AxisGroup.Secondary;

            // Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Top;

            #endregion #ChangeSeriesType
        }
        static void ChangeSeriesArguments(IWorkbook workbook)
        {
            #region #ChangeSeriesArgumentsAndValues
            Worksheet worksheet = workbook.Worksheets["Sheet1"];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            workbook.BeginUpdate();

            // Create a chart.
            Chart chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet[0,0]);
            // Specify arguments.
            chart.Series[0].Arguments = new CellValue[] {1,2,3};
            // Specify values.
            chart.Series[0].Values = new CellValue[] { 30, 20, 10 };

            workbook.EndUpdate();
            #endregion #ChangeSeriesArgumentsAndValues
        }
    }
}
