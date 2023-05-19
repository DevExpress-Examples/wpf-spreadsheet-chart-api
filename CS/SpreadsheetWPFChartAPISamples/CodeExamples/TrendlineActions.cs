using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetChartAPIActions
{
    public static class TrendlineActions
    {
        static void Trendlines(IWorkbook workbook)
        {
            #region #Trendlines
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnStacked);
            chart.SelectData(worksheet["C2:F3"], ChartDataDirection.Row);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Show data labels.
            chart.Views[0].DataLabels.ShowValue = true;

            // Display a polynomial trendline.
            chart.Series[0].Trendlines.Add(ChartTrendlineType.Polynomial);

            #endregion #Trendlines
        }

        static void TrendlineCustomization(IWorkbook workbook)
        {
            #region #TrendlineCustomization
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ScatterMarkers);
            chart.SelectData(worksheet["C2:F3"], ChartDataDirection.Row);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Set the minimum and maximum values for the chart value axis.
            Axis axis = chart.PrimaryAxes[1];
            axis.Scaling.AutoMax = false;
            axis.Scaling.AutoMin = false;
            axis.Scaling.Min = 0.6;
            axis.Scaling.Max = 1.0;
            chart.PrimaryAxes[1].MajorGridlines.Visible = false;

            // Display a polynomial trendline.
            chart.Series[0].Trendlines.Add(ChartTrendlineType.Polynomial);

            // Customize the trendline.
            Trendline tline = chart.Series[0].Trendlines[0];
            tline.DisplayEquation = true;
            tline.CustomName = "Trend";
            tline.DisplayRSquare = true;
            tline.Backward = 1;
            tline.Forward = 2;
            tline.Outline.SetSolidFill(Color.Red);

            #endregion #TrendlineCustomization
        }

        static void TrendlineLabel(IWorkbook workbook)
        {
            #region #TrendlineLabel
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ScatterMarkers);
            chart.SelectData(worksheet["C2:F3"], ChartDataDirection.Row);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Display a polynomial trendline.
            chart.Series[0].Trendlines.Add(ChartTrendlineType.Polynomial);

            // Customize the trendline.
            Trendline tline = chart.Series[0].Trendlines[0];
            tline.DisplayEquation = true;
            tline.CustomName = "Trend";
            tline.DisplayRSquare = true;
            tline.Outline.SetSolidFill(Color.Red);

            // Format the trend label.
            TrendlineLabel tlabel = tline.Label;
            tlabel.Font.Name = "Tahoma";
            tlabel.Font.Italic = true;
            tlabel.Fill.SetGradientFill(ShapeGradientType.Linear, Color.Orange, Color.White);
            // Position the label in the right quarter of the chart area.
            tlabel.Layout.Left.SetPosition(LayoutMode.Edge, 0.75);

            #endregion #TrendlineLabel
        }

    }
}
