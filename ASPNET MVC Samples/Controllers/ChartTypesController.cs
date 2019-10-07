using ASPNET_MVC_Samples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_Samples.Controllers
{
    public class ChartTypesController : Controller
    {
        public ActionResult Column()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(10), _jsonSetting);

            return View();
        }

        public ActionResult Line()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(1000), _jsonSetting);

            return View();
        }

        public ActionResult Bar()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(4), _jsonSetting);

            return View();
        }

        public ActionResult Area()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(10), _jsonSetting);

            return View();
        }

        public ActionResult Pie()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);

            return View();
        }

        public ActionResult Doughnut()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);

            return View();
        }

        public ActionResult Spline()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);

            return View();
        }

        public ActionResult StepLine()
        {
            return View();
        }

        public ActionResult SplineArea()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(12), _jsonSetting);

            return View();
        }

        public ActionResult Scatter()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(50), _jsonSetting);

            return View();
        }

        public ActionResult Bubble()
        {
            return View();
        }

        public ActionResult StackedColumn()
        {
			//Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
			//ViewBag.DataPoints1 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);
			//ViewBag.DataPoints2 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);

			return View();
        }

        public ActionResult StackedBar()
        {
			//Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
			//ViewBag.DataPoints1 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints2 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints3 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints4 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);

			return View();
        }

        public ActionResult StackedArea()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForDateTimeAxis(7), _jsonSetting);

            return View();
        }

        public ActionResult StackedColumn100()
        {
			//Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
			//ViewBag.DataPoints1 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);
			//ViewBag.DataPoints2 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);

			return View();
        }

        public ActionResult StackedBar100()
        {
			//Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
			//ViewBag.DataPoints1 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints2 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints3 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints4 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints5 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints6 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints7 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);
			//ViewBag.DataPoints8 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(9), _jsonSetting);

			return View();
        }

        public ActionResult StackedArea100()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(7), _jsonSetting);

            return View();
        }

        public ActionResult StepArea()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(25), _jsonSetting);

            return View();
        }

        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

    }
}