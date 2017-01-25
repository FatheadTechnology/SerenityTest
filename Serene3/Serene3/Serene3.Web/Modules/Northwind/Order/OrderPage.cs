﻿

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Northwind/Order", url: "~/Northwind/Order", permission: "Northwind/" + R.ActionIndex)]

namespace Serene3.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Northwind/Order"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrderRow))]
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Northwind.Order.OrderIndex);
        }
    }
}