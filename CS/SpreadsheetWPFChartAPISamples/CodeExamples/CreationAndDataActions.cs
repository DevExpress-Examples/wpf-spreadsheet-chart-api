using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using DevExpress.Utils;

namespace SpreadsheetChartAPIActions {
    public static class CreationAndDataActions {
        static void CreateChartFromRange(IWorkbook workbook) {
            #region #CreateChartFromRange
            Worksheet worksheet = workbook.Worksheets["chartTask1"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a pie chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.Pie3D, worksheet["B2:C7"]);
            chart.TopLeftCell = worksheet.Cells["E2"];
            chart.BottomRightCell = worksheet.Cells["K15"];

            // Set the chart style.
            chart.Style = ChartStyle.ColorGradient;

            #endregion #CreateChartFromRange
        }

        static void CreateChartAndSelectData(IWorkbook workbook)
        {
            #region #CreateChartAndSelectData
            Worksheet worksheet = workbook.Worksheets["chartTask2"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chartRowData = worksheet.Charts.Add(ChartType.ColumnStacked);
            chartRowData.TopLeftCell = worksheet.Cells["E3"];
            chartRowData.BottomRightCell = worksheet.Cells["J12"];

            // Select chart data.
            chartRowData.SelectData(worksheet["B3:C8"]);
            #endregion #CreateChartAndSelectData
        }

        static void CreateChartAndSelectDataDirection(IWorkbook workbook) {
            #region #CreateChartAndSelectDataDirection
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chartRowData = worksheet.Charts.Add(ChartType.ColumnClustered);
            chartRowData.TopLeftCell = worksheet.Cells["D3"];
            chartRowData.BottomRightCell = worksheet.Cells["I14"];

            // Select chart data by rows.
            chartRowData.SelectData(worksheet["B2:F6"], ChartDataDirection.Row);

            // Create a chart and specify its location.
            Chart chartColumnData = worksheet.Charts.Add(ChartType.ColumnClustered);
            chartColumnData.TopLeftCell = worksheet.Cells["K3"];
            chartColumnData.BottomRightCell = worksheet.Cells["N14"];

            // Select chart data by columns.
            chartColumnData.SelectData(worksheet["B2:F6"], ChartDataDirection.Column);
            #endregion #CreateChartAndSelectDataDirection
        }

        static void CreateChartWithComplexRange(IWorkbook workbook) {
            #region #CreateChartWithComplexRange
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];

            // Add chart series using worksheet ranges as the data sources.
            chart.Series.Add(worksheet["D2"], worksheet["B3:B6"], worksheet["D3:D6"]);
            chart.Series.Add(worksheet["F2"], worksheet["B3:B6"], worksheet["F3:F6"]);

            #endregion #CreateChartWithComplexRange
        }

        static void CreateChartWithLiteralData(IWorkbook workbook) {
            #region #CreateChartWithLiteralData
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            worksheet.Columns[0].WidthInCharacters = 2.0;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart.TopLeftCell = worksheet.Cells["B2"];
            chart.BottomRightCell = worksheet.Cells["H15"];

            // Add a series bound to a set of literal data.
            Series series_of_literal = chart.Series.Add(
                new CellValue[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" },
                new CellValue[] { 50, 100, 30, 104, 87, 150 });

            #endregion #CreateChartWithLiteralData
        }

        static void ChangeDataReference(IWorkbook workbook) {
            #region #ChangeDataReference
            Worksheet worksheet = workbook.Worksheets["chartTask3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a chart and specify its location.
            Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart.TopLeftCell = worksheet.Cells["H2"];
            chart.BottomRightCell = worksheet.Cells["N14"];
            // Add series using a worksheet range as the data source.
            chart.Series.Add(worksheet["D2"], worksheet["B3:B6"], worksheet["D3:D6"]);
            chart.Series.Add(worksheet["F2"], worksheet["B3:B6"], worksheet["F3:F6"]);

            // Change the data range for the series values.
            chart.Series[1].Values = ChartData.FromRange(worksheet["E3:E6"]);

            // Specify the cell that is the source for the series name.
            chart.Series[1].SeriesName.SetReference(worksheet["E2"]);

            #endregion #ChangeDataReference
        }
    }
}
