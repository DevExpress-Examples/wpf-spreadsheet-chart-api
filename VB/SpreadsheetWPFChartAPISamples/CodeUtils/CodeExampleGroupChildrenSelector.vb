Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Grid
Imports SpreadsheetChartAPISamples
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SpreadsheetWPFChartAPISamples
	Public Class CodeExampleGroupChildrenSelector
		Implements IChildNodesSelector
		Private Function SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
			If TypeOf item Is CodeExampleGroup Then
				Return (CType(item, CodeExampleGroup)).Examples
			End If
			Return Nothing
		End Function
	End Class
End Namespace
