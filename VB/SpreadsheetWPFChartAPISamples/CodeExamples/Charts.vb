Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils
Imports System.Windows.Forms

Namespace SpreadsheetChartAPIActions
	Public NotInheritable Class Charts
		Private Sub New()
		End Sub
		Private Shared Sub PieChart(ByVal workbook As IWorkbook)
'			#Region "#PieChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.PieExploded, worksheet("B2:C7"))
			chart.TopLeftCell = worksheet.Cells("E2")
			chart.BottomRightCell = worksheet.Cells("K15")

			' Set the chart style
			chart.Style = ChartStyle.ColorGradient

			' Hide the legend
			chart.Legend.Visible = False

			' Rotate the pie chart view
			chart.Views(0).FirstSliceAngle = 100

			' Display data labels
			Dim dataLabels As DataLabelOptions = chart.Views(0).DataLabels
			dataLabels.ShowCategoryName = True
			dataLabels.ShowPercent = True
			dataLabels.Separator = Constants.vbLf

'			#End Region ' #PieChart
		End Sub

		Private Shared Sub BarChart(ByVal workbook As IWorkbook)
'			#Region "#BarChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.BarFullStacked)
			chart.TopLeftCell = worksheet.Cells("E3")
			chart.BottomRightCell = worksheet.Cells("K14")

			' Select chart data
			chart.SelectData(worksheet("B3:C8"), ChartDataDirection.Row)

			' Display the chart title
			chart.Title.Visible = True
			chart.Title.SetReference(worksheet("B1"))

			' Change legend position
			chart.Legend.Position = LegendPosition.Bottom

			' Hide the category axis
			chart.PrimaryAxes(0).Visible = False

			' Set major unit of the value axis
			chart.PrimaryAxes(1).MajorUnit = 0.2

'			#End Region ' #BarChart
		End Sub

		Private Shared Sub ColumnChart(ByVal workbook As IWorkbook)
'			#Region "#ColumnChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Add series
			chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
			chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))

			' Display the chart title
			chart.Title.Visible = True
			chart.Title.SetValue("Mobile OS market share")

			' Customize the appearance and scale of the axes
			Dim axis As Axis = chart.PrimaryAxes(0)
			axis.MajorTickMarks = AxisTickMarks.None
			axis = chart.PrimaryAxes(1)
			axis.Outline.SetNoFill()
			axis.MajorTickMarks = AxisTickMarks.None
			axis.NumberFormat.FormatCode = "0%"
			axis.NumberFormat.IsSourceLinked = False
			axis.Scaling.AutoMax = False
			axis.Scaling.Max = 1
			axis.Scaling.AutoMin = False
			axis.Scaling.Min = 0

			' Set the gap width between data series
			Dim view As ChartView = chart.Views(0)
			view.GapWidth = 75

			' Display data labels
			view.DataLabels.ShowValue = True
			view.DataLabels.NumberFormat.FormatCode = "0%"
			view.DataLabels.NumberFormat.IsSourceLinked = False

			' Set the chart style
			chart.Style = ChartStyle.ColorGradient

'			#End Region ' #ColumnChart
		End Sub

		Private Shared Sub ComplexChart(ByVal workbook As IWorkbook)
'			#Region "#ComplexChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D8"))
			chart.TopLeftCell = worksheet.Cells("F2")
			chart.BottomRightCell = worksheet.Cells("L15")

			' Change the chart type of the second series
			chart.Series(1).ChangeType(ChartType.Line)
			chart.Series(1).Smooth = True

			' Use secondary axes
			chart.Series(1).AxisGroup = AxisGroup.Secondary

			' Specify the chart style
			chart.Style = ChartStyle.ColorGradient

			' Set the position of the legend
			chart.Legend.Position = LegendPosition.Bottom

'			#End Region ' #ComplexChart
		End Sub

		Private Shared Sub DoughnutChart(ByVal workbook As IWorkbook)
'			#Region "#DoughnutChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.Doughnut)
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Add the data series
			chart.Series.Add(worksheet("E2"), worksheet("B3:B6"), worksheet("E3:E6"))

			' Display the chart title
			chart.Title.Visible = True
			chart.Title.SetValue("Mobile OS market share Q4'13")

			' Change the hole size
			chart.Views(0).HoleSize = 60

			' Display the data labels
			chart.Views(0).DataLabels.ShowPercent = True

'			#End Region ' #DoughnutChart
		End Sub

		Private Shared Sub Pie3dChart(ByVal workbook As IWorkbook)
'			#Region "#Pie3dChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.Pie3D)
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N14")

			' Add the data series
			chart.Series.Add(worksheet("E2"), worksheet("B3:B6"), worksheet("E3:E6"))

			' Set the explosion value for the slice
			chart.Series(0).CustomDataPoints.Add(2).Explosion = 25

			' Set the rotation of the  3-D chart view
			chart.View3D.YRotation = 255

			' Set the chart style
			chart.Style = ChartStyle.ColorGradient

'			#End Region ' #Pie3dChart
		End Sub

		Private Shared Sub ScatterChart(ByVal workbook As IWorkbook)
'			#Region "#ScatterChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartScatter")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.ScatterLineMarkers, worksheet("C2:D52"))
			chart.TopLeftCell = worksheet.Cells("F2")
			chart.BottomRightCell = worksheet.Cells("L15")

			' Set the marker symbol
			chart.Series(0).Marker.Symbol = MarkerStyle.Circle

			' Set appearance and scale of the X axis
			Dim axis As Axis = chart.PrimaryAxes(0)
			axis.Scaling.AutoMax = False
			axis.Scaling.AutoMin = False
			axis.Scaling.Max = 60.0
			axis.Scaling.Min = -60.0
			axis.MajorGridlines.Visible = True

			' Set appearance and scale of the Y axis
			axis = chart.PrimaryAxes(1)
			axis.Scaling.AutoMax = False
			axis.Scaling.AutoMin = False
			axis.Scaling.Max = 50.0
			axis.Scaling.Min = -50.0
			axis.MajorUnit = 10.0

'			#End Region ' #ScatterChart
		End Sub

		Private Shared Sub StockChart(ByVal workbook As IWorkbook)
'			#Region "#StockChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartStock")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.StockOpenHighLowClose, worksheet("B2:F7"))
			chart.TopLeftCell = worksheet.Cells("H2")
			chart.BottomRightCell = worksheet.Cells("N15")

			' Display the chart title
			chart.Title.Visible = True
			chart.Title.SetValue("NASDAQ:MSFT")

			' Hide the legend
			chart.Legend.Visible = False

			' Set appearance and scale of the value axis
			Dim axis As Axis = chart.PrimaryAxes(1)
			axis.Scaling.AutoMax = False
			axis.Scaling.Max = 40.5
			axis.Scaling.AutoMin = False
			axis.Scaling.Min = 38.5
			axis.MajorUnit = 0.25

			' Format the axis labels
			axis.NumberFormat.FormatCode = "#0.00"
			axis.NumberFormat.IsSourceLinked = False

			' Display the axis title
			axis.Title.Visible = True
			axis.Title.SetValue("Price in USD")

'			#End Region ' #StockChart
		End Sub
		Private Shared Sub BubbleChart(ByVal workbook As IWorkbook)
'			#Region "#BubbleChart"
			Dim worksheet As Worksheet = workbook.Worksheets("chartBubble")
			workbook.Worksheets.ActiveWorksheet = worksheet

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.Bubble3D)
			chart.TopLeftCell = worksheet.Cells("F2")
			chart.BottomRightCell = worksheet.Cells("L15")

			Dim s1 As Series = chart.Series.Add(worksheet("A3"), worksheet("C3:C7"), worksheet("D3:D7"))
			s1.BubbleSize = ChartData.FromRange(worksheet("E3:E7"))
			Dim s2 As Series = chart.Series.Add(worksheet("A9"), worksheet("C9:C13"), worksheet("D9:D13"))
			s2.BubbleSize = ChartData.FromRange(worksheet("E9:E13"))

			' Set the chart style
			chart.Style = ChartStyle.ColorGradient
			' Set the bubble size 1.5x relative to the default setting.
			chart.Views(0).BubbleScale = 150

			' Hide the legend
			chart.Legend.Visible = False

			' Display data labels
			Dim dataLabels As DataLabelOptions = chart.Views(0).DataLabels
			dataLabels.ShowBubbleSize = True

			' Set the minimum and maximum values for the chart value axis.
			Dim axis As Axis = chart.PrimaryAxes(1)
			axis.Scaling.AutoMax = False
			axis.Scaling.Max = 82
			axis.Scaling.AutoMin = False
			axis.Scaling.Min = 64
'			#End Region ' #BubbleChart
		End Sub

		Private Shared Sub ChangeChartType(ByVal workbook As IWorkbook)
'			#Region "#ChangeChartType"
			Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
			workbook.Worksheets.ActiveWorksheet = worksheet
			Dim type1 As ChartType = ChartType.ScatterSmoothMarkers
			' If a new chart type cannot be created with existing data, an exception is thrown.
			'ChartType type1 = ChartType.StockHighLowClose;
			Dim type2 As ChartType = ChartType.ColumnClustered

			' Create a chart and specify its location
			Dim chart As Chart = worksheet.Charts.Add(ChartType.PieExploded, worksheet("B2:C7"))

			' Change the chart type. 
			Try
				chart.ChangeType(type1)
			Catch e As Exception
				MessageBox.Show(e.Message, "Incompatible chart type")
				chart.ChangeType(type2)
			End Try
'			#End Region ' #ChangeChartType
		End Sub
	End Class
End Namespace
