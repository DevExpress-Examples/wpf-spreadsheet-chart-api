using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class StyleActions {
        static void SetChartStyle(IWorkbook workbook) {
            #region #SetChartStyle
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Set the chart style.
            chart.Style = ChartStyle.Accent1Dark;

            #endregion #SetChartStyle
        }

        static void CustomSeriesColor(IWorkbook workbook) {
            #region #CustomSeriesColor
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet["B2:D4"]);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Change the series colors.
            chart.Series[0].Fill.SetSolidFill(Color.FromArgb(0x66, 0xff, 0x66));
            chart.Series[1].Fill.SetSolidFill(Color.FromArgb(0xff, 0xff, 0x33));

            #endregion #CustomSeriesColor
        }

        static void Transparency(IWorkbook workbook) {
            #region #Transparency
            Worksheet worksheet = workbook.Worksheets["chartTask4"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.Line, worksheet["B3:D8"]);
            chart.TopLeftCell = worksheet.Cells["F3"];
            chart.BottomRightCell = worksheet.Cells["L14"];

            // Customize the chart area and the plot area appearance.
            chart.Fill.SetNoFill();
            chart.Outline.SetSolidFill(Color.FromArgb(0x99, 0x99, 0x99));
            chart.PlotArea.Fill.SetSolidFill(Color.FromArgb(0x22, 0x99, 0x99, 0x99));

            // Specify the position of the legend.
            chart.Legend.Position = LegendPosition.Top;

            // Use a secondary axis.
            chart.Series[1].AxisGroup = AxisGroup.Secondary;

            // Customize the axis scale and appearance.
            Axis axis = chart.PrimaryAxes[0];
            axis.Outline.SetNoFill();
            axis.MajorTickMarks = AxisTickMarks.None;

            axis = chart.PrimaryAxes[1];
            axis.Outline.SetNoFill();
            axis.MajorTickMarks = AxisTickMarks.None;
            axis.MajorGridlines.Visible = false;
            axis.Scaling.AutoMax = false;
            axis.Scaling.AutoMin = false;
            axis.Scaling.Max = 1400;
            axis.Scaling.Min = 0;

            axis = chart.SecondaryAxes[1];
            axis.Outline.SetNoFill();
            axis.MajorTickMarks = AxisTickMarks.None;
            axis.Scaling.AutoMax = false;
            axis.Scaling.AutoMin = false;
            axis.Scaling.Max = 390;
            axis.Scaling.Min = 270;

            #endregion #Transparency
        }
    }
}
