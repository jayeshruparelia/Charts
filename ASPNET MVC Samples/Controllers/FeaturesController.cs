﻿using ASPNET_MVC_Samples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_Samples.Controllers
{
    public class FeaturesController : Controller
    {
        // GET: Features
        public ActionResult ZoomingPanning()
        {
            JsonSerializerSettings jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

            ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(1000), jsonSetting);

            return View();
        }

        // GET: Features
        public ActionResult ExportChart()
        {
            return View();
        }

        // GET: Features
        public ActionResult LogAxis()
        {
            return View();
        }

        // GET: Features
        public ActionResult ReverseAxis()
        {
            return View();
        }
        
        // GET: Features
        public ActionResult DateTime()
        {
            return View();
        }

        // GET: Features
        public ActionResult EventHandling()
        {
            return View();
        }

        // GET: Features
        public ActionResult StripLines()
        {
            return View();
        }

        // GET: Features
        public ActionResult MultipleYAxis()
        {
            return View();
        }

        // GET: Features
        public ActionResult MultiSeriesChart()
        {
            return View();
        }
    }
}