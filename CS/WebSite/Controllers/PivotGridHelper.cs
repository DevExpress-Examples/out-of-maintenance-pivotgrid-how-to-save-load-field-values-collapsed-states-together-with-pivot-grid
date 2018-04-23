using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System.IO;
using System.Reflection;
using System.Drawing;

public static class PivotGridHelper {
    private static PivotGridSettings _pivotGridSettings;

    public static PivotGridSettings Settings {
        get {
            if (_pivotGridSettings == null)
                _pivotGridSettings = CreatePivotGridSettings();
            return _pivotGridSettings;
        }
    }

    static string olapCS = "provider=MSOLAP;data source=\"http://demos.devexpress.com/Services/OLAP/msmdpump.d" +
                    "ll\";initial catalog=\"Adventure Works DW Standard Edition\";cube name=\"Adventure W" +
                    "orks\"";
    public static string OlapConnectionString { get { return olapCS; } }

    private static PivotGridSettings CreatePivotGridSettings() {
        PivotGridSettings settings = new PivotGridSettings();

        settings.Name = "pivotGrid";
        settings.CallbackRouteValues = new { Controller = "Home", Action = "PivotGridPartial" };
        settings.OptionsView.ShowHorizontalScrollBar = true;
        settings.Width = new System.Web.UI.WebControls.Unit(90, System.Web.UI.WebControls.UnitType.Percentage);
        settings.Fields.Add("[Measures].[Sales Amount]", PivotArea.DataArea);
        settings.Fields.Add("[Product].[Product Categories].[Category]", PivotArea.RowArea);
        settings.Fields.Add("[Date].[Calendar Year].[Calendar Year]", PivotArea.ColumnArea);

        return settings;
    }
}
