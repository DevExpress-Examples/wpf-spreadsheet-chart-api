using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class TitlesActions {
        static void ShowChartTitle(IWorkbook workbook) {
            #region #ShowChartTitle
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet["B4:C7"]);
            chart.TopLeftCell = worksheet.Cells["E3"];
            chart.BottomRightCell = worksheet.Cells["K14"];

            // Display default chart title.
            chart.Title.Visible = true;
            // Display the chart legend. 
            chart.Legend.Visible = false;
            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;

            #endregion #ShowChartTitle
        }

        static void SetChartTitleText(IWorkbook workbook) {
            #region #SetChartTitleText
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet["B4:C7"]);
            chart.TopLeftCell = worksheet.Cells["E3"];
            chart.BottomRightCell = worksheet.Cells["K14"];

            // Display the chart title and specify the title text.
            chart.Title.Visible = true;
            chart.Title.SetValue("Market share Q3'13");

            // Hide the chart legend.
            chart.Legend.Visible = false;
            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;

            #endregion #SetChartTitleText
        }

        static void LinkChartTitleToCellRange(IWorkbook workbook) {
            #region #LinkChartTitleToCellRange
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet["B4:C7"]);
            chart.TopLeftCell = worksheet.Cells["E3"];
            chart.BottomRightCell = worksheet.Cells["K14"];

            // Display the chart title and set the source cell for the title text.
            chart.Title.Visible = true;
            chart.Title.SetReference(worksheet["B1"]);

            // Hide the legend.
            chart.Legend.Visible = false;
            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;

            #endregion #LinkChartTitleToCellRange
        }


        static void ShowAxisTitle(IWorkbook workbook) {
            #region #ShowAxisTitle
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet["B4:C7"]);
            chart.TopLeftCell = worksheet.Cells["E3"];
            chart.BottomRightCell = worksheet.Cells["K14"];

            // Show the axis title.
            chart.PrimaryAxes[1].Title.Visible = true;
            // Hide the legend.
            chart.Legend.Visible = false;
            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;

            #endregion #ShowAxisTitle
        }

        static void SetAxisTitleText(IWorkbook workbook) {
            #region #SetAxisTitleText
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet["B4:C7"]);
            chart.TopLeftCell = worksheet.Cells["E3"];
            chart.BottomRightCell = worksheet.Cells["K14"];

            // Specify the axis title text.
            chart.PrimaryAxes[1].Title.Visible = true;
            chart.PrimaryAxes[1].Title.SetValue("Shipment in millions of units");
            // Hide the legend.
            chart.Legend.Visible = false;
            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;

            #endregion #SetAxisTitleText
        }

        static void LinkAxisTitleToCellRange(IWorkbook workbook) {
            #region #LinkAxisTitleToCellRange
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet["B4:C7"]);
            chart.TopLeftCell = worksheet.Cells["E3"];
            chart.BottomRightCell = worksheet.Cells["K14"];

            // Bind the axis title text to a worksheet cell.
            chart.PrimaryAxes[1].Title.Visible = true;
            chart.PrimaryAxes[1].Title.SetReference(worksheet["C3"]);
            // Hide the legend.
            chart.Legend.Visible = false;
            // Specify that each data point in the series has a different color.
            chart.Views[0].VaryColors = true;

            #endregion #LinkAxisTitleToCellRange
        }
    }
}
