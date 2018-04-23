using DevExpress.Xpf.Grid;
using SpreadsheetChartAPISamples;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetWPFChartAPISamples
{
    public class CodeExampleGroupChildrenSelector : IChildNodesSelector
    {
        IEnumerable IChildNodesSelector.SelectChildren(object item)
        {
            if (item is CodeExampleGroup)
                return ((CodeExampleGroup)item).Examples;
            return null;
        }
    }
}
