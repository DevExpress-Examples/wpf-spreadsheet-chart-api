using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class DataLabelsActions {
        static void ShowDataLabels(IWorkbook workbook) {
            #region #ShowDataLabels
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Show data labels.
            chart.Views[0].DataLabels.ShowValue = true;

            #endregion #ShowDataLabels
        }

        static void SetDataLabelsPosition(IWorkbook workbook) {
            #region #SetDataLabelsPosition
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Display data labels and specify their position within the chart.
            chart.Views[0].DataLabels.ShowValue = true;
            chart.Views[0].DataLabels.LabelPosition = DataLabelPosition.Center;

            #endregion #SetDataLabelsPosition
        }

        static void DataLabelsNumberFormat(IWorkbook workbook) {
            #region #DataLabelsNumberFormat
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Display data labels and specify their position within the chart.
            chart.Views[0].DataLabels.ShowValue = true;
            chart.Views[0].DataLabels.LabelPosition = DataLabelPosition.Center;

            // Format data labels.
            chart.Views[0].DataLabels.NumberFormat.FormatCode = "0%";
            chart.Views[0].DataLabels.NumberFormat.IsSourceLinked = false;

            #endregion #DataLabelsNumberFormat
        }

        static void DataLabelsPerSeries(IWorkbook workbook) {
            #region #DataLabelsPerSeries
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Display data labels for the second series.
            chart.Series[1].CustomDataLabels.ShowValue = true;
            chart.Series[1].UseCustomDataLabels = true;

            #endregion #DataLabelsPerSeries
        }

        static void DataLabelsPerPoint(IWorkbook workbook) {
            #region #DataLabelsPerPoint
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Display the data label for the last point of the second series.
            chart.Series[1].CustomDataLabels.Add(1).ShowValue = true;
            chart.Series[1].UseCustomDataLabels = true;

            #endregion #DataLabelsPerPoint
        }

        static void DataLabelsSeparator(IWorkbook workbook) {
            #region #DataLabelsSeparator
            Worksheet worksheet = workbook.Worksheets["chartTask1"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.Pie, worksheet["B2:C7"]);
            chart.TopLeftCell = worksheet.Cells["E2"];
            chart.BottomRightCell = worksheet.Cells["K15"];

            // Display the category name and percentage.
            DataLabelOptions dataLabels = chart.Views[0].DataLabels;
            dataLabels.ShowCategoryName = true;
            dataLabels.ShowPercent = true;
            dataLabels.Separator = "\n";

            // Set the chart style.
            chart.Style = ChartStyle.ColorGradient;
            // Hide the legend.
            chart.Legend.Visible = false;
            // Set the angle of the first pie-chart slice.
            chart.Views[0].FirstSliceAngle = 100;

            #endregion #DataLabelsSeparator
        }

        static void DataLabelsFromCells(IWorkbook workbook)
        {
            #region #DataLabelsFromCells
            Worksheet worksheet = workbook.Worksheets["chartTask5"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:C8"]);
            chart.TopLeftCell = worksheet.Cells["F2"];
            chart.BottomRightCell = worksheet.Cells["L15"];
            // Specify the chart style
            chart.Style = ChartStyle.ColorGradient;

            chart.Series[0].UseCustomDataLabels = true;
            var customDataLabels = chart.Series[0].CustomDataLabels;
            customDataLabels.SetReference("D3:D8");
            #endregion #DataLabelsFromCells
        }
    }
}
