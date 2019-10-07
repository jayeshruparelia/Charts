using ASPNET_MVC_Samples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_Samples.Controllers
{
    public class HowToController : Controller
    {
        // GET: HowTo
        public ActionResult EnableDisableDS()
        {
            return View();
        }

        // GET: HowTo
        public ActionResult LiveChart()
        {
            JsonSerializerSettings jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

            ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(1));
            return View();
        }

        // GET: HowTo
        public ActionResult AddDataPointsFromUserInput()
        {
            return View();
        }

        // GET: HowTo
        public ActionResult MultipleChartsInAPage()
        {
            return View();
        }

        // GET: HowTo
        public ActionResult PlayStopLiveChart()
        {
            return View();
        }

        // GET: HowTo
        public ActionResult SyncMultipleCharts()
        {
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(1000));
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(1000));

            return View();
        }

        // GET: HowTo
        public ActionResult CreateChartFromJSON()
        {
            return View();
        }

        // GET: HowTo
        public ActionResult DataFromDataBase()
        {
            try
            {
                ViewBag.DataPoints = JsonConvert.SerializeObject(_db.Points.ToList(), _jsonSetting);

                return View();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return View("Error");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return View("Error");
            }
        }
        private DataBaseEntities _db = new DataBaseEntities();

        // GET: HowTo
        public ActionResult CreateChartFromXML()
        {
            return View();
        }

        // GET: HowTo
        public ActionResult CreateChartFromCSV()
        {
            return View();
        }

        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
    }
}