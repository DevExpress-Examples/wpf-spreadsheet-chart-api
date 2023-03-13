Imports DevExpress.Xpf.Grid
Imports SpreadsheetChartAPISamples
Imports System.Collections

Namespace SpreadsheetWPFChartAPISamples

    Public Class CodeExampleGroupChildrenSelector
        Implements IChildNodesSelector

        Private Function SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
            If TypeOf item Is CodeExampleGroup Then Return CType(item, CodeExampleGroup).Examples
            Return Nothing
        End Function
    End Class
End Namespace
