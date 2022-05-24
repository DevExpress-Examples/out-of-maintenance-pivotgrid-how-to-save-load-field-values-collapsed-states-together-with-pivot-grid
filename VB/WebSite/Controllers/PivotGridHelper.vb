Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.IO
Imports System.Reflection
Imports System.Drawing

Public NotInheritable Class PivotGridHelper
	Private Shared _pivotGridSettings As PivotGridSettings

	Private Sub New()
	End Sub
	Public Shared ReadOnly Property Settings() As PivotGridSettings
		Get
			If _pivotGridSettings Is Nothing Then
				_pivotGridSettings = CreatePivotGridSettings()
			End If
			Return _pivotGridSettings
		End Get
	End Property

	Private Shared olapCS As String = "provider=MSOLAP;data source=""https://demos.devexpress.com/Services/OLAP/msmdpump.d" & "ll"";initial catalog=""Adventure Works DW Standard Edition"";cube name=""Adventure W" & "orks"""
	Public Shared ReadOnly Property OlapConnectionString() As String
		Get
			Return olapCS
		End Get
	End Property

	Private Shared Function CreatePivotGridSettings() As PivotGridSettings
		Dim settings As New PivotGridSettings()

		settings.Name = "pivotGrid"
		settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "PivotGridPartial"}
		settings.OptionsView.ShowHorizontalScrollBar = True
		settings.Width = New System.Web.UI.WebControls.Unit(90, System.Web.UI.WebControls.UnitType.Percentage)
		settings.Fields.Add("[Measures].[Sales Amount]", PivotArea.DataArea)
		settings.Fields.Add("[Product].[Product Categories].[Category]", PivotArea.RowArea)
		settings.Fields.Add("[Date].[Calendar Year].[Calendar Year]", PivotArea.ColumnArea)

		Return settings
	End Function
End Class
