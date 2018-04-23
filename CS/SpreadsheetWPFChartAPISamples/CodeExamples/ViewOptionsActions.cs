using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class ViewOptionsActions {
        static void ShowAutomaticMarkers(IWorkbook workbook) {
            #region #ShowAutomaticMarkers
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Display markers using automatic style.
            chart.Series[0].Marker.Symbol = MarkerStyle.Auto;
            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #ShowAutomaticMarkers
        }

        static void ShowCustomMarkers(IWorkbook workbook) {
            #region #ShowCustomMarkers
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Display markers and specify the marker style.
            chart.Series[0].Marker.Symbol = MarkerStyle.Circle;
            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #ShowCustomMarkers
        }

        static void SetMarkerSize(IWorkbook workbook) {
            #region #SetMarkerSize
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Display markers and specify the marker style and size.
            chart.Series[0].Marker.Symbol = MarkerStyle.Circle;
            chart.Series[0].Marker.Size = 15;
            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #SetMarkerSize
        }

        static void SmoothLines(IWorkbook workbook) {
            #region #SmoothLines
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Turn on curve smoothing.
            chart.Series[0].Smooth = true;
            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #SmoothLines
        }

        static void GapWidth(IWorkbook workbook) {
            #region #GapWidth
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Set the gap width between data series.
            chart.Views[0].GapWidth = 33;
            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #GapWidth
        }

        static void VaryColorsByPoint(IWorkbook workbook) {
            #region #VaryColorsByPoint
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];

            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;
            // Hide the legend.
            chart.Legend.Visible = false;

            #endregion #VaryColorsByPoint
        }

    }
}
