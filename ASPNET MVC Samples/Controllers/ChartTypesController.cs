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
        public ActionResult Dashboard()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            var result = DataService.GetDashboardPieChart();
            ViewBag.PieDataPoints = JsonConvert.SerializeObject(result);

            var result2 = DataService.GetDashboardTop10CityChart();
            ViewBag.Top10CityDataPoints = JsonConvert.SerializeObject(result2);
            return View();
        }

        public ActionResult Daily()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            var result = DataService.GetChartData("food_utilization_all", 3, DateTime.Now.AddDays(-30), DateTime.Now, ChartType.Daily);
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(result._dataPoint1.TypeOfWasteData);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(result._dataPoint2.TypeOfWasteData);

            return View();
        }

        public ActionResult Monthly()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            //ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(10), _jsonSetting);

            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            var result = DataService.GetChartData("food_utilization_monthly", 3, DateTime.Now.AddDays(-30), DateTime.Now, ChartType.Monthly);
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(result._dataPoint1.TypeOfWasteData);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(result._dataPoint2.TypeOfWasteData);

            return View();
        }

        public ActionResult ComparisionByCity()
        {
            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            var result = DataService.GetChartData("food_compare_city", 3, DateTime.Now.AddDays(-30), DateTime.Now, ChartType.Daily);
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(result._dataPoint1.TypeOfWasteData);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(result._dataPoint2.TypeOfWasteData);

            return View();
        }


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
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(5), _jsonSetting);

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