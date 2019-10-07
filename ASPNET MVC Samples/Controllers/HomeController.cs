using ASPNET_MVC_Samples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_Samples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			
			// Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
			//ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(20));

			return View();
        }
    }
}