using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetChartAPISamples
{
    public static class FinalCallHelper
    {
        public static string CheckModule(ExampleLanguage lang, string regionName)
        {
            List<string> modules = new List<string> {"Pie Of Pie Chart", "Custom Walls and Floor"};
            if (modules.Contains(regionName))
            {
                if (lang == ExampleLanguage.Csharp) return finalCallCS;
                if (lang == ExampleLanguage.VB) return finalCallVB;
            }

            return string.Empty;
        }

            const string finalCallCS =
    "worksheet = workbook.Worksheets[\"blankSheet\"];\r\n" +
    "workbook.Worksheets.ActiveWorksheet = worksheet;\r\n" +
    "worksheet.Cells[\"B2\"].Value =" +
        "\"SpeadsheetControl does not visualize this sample correctly.\" + Environment.NewLine +" +
        "\"However, property values are loaded and stored in supported formats,\" + Environment.NewLine +" +
        "\"so that you can modify them programmatically\" + Environment.NewLine +" +
        "\"and display the result in Microsoft Excel.\";";

            const string finalCallVB =
    "worksheet = workbook.Worksheets(\"blankSheet\")\r\n" +
    "workbook.Worksheets.ActiveWorksheet = worksheet\r\n" +
    "worksheet.Cells(\"B2\").Value = " +
    "\"SpeadsheetControl does not visualize this sample correctly.\"" +
    "& Constants.vbCrLf & \"However, property values are loaded and stored in supported formats,\"" +
    "& Constants.vbCrLf & \"and you can modify them programmatically.\"";
        }

}
    