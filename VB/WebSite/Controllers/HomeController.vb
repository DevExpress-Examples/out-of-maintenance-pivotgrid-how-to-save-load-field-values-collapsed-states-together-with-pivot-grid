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

Namespace DevExpressMvcApplication17.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
			Return View()
		End Function
		Public Function PivotGridPartial() As ActionResult
			Return PartialView("PivotGridPartial")
		End Function

		<HttpPost> _
		Public Function PostPivotGridState() As ActionResult
			ViewBag.Message = "The PivotGrid state has been restored successfully"
			Return View("Index")
		End Function
	End Class
End Namespace