using ASPNET_MVC_Samples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace ASPNET_MVC_Samples.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult DataPoints(int count = 10, string type = "json")
        {
            _dataPoints = DataService.GetRandomDataForNumericAxis(count);

            switch (type)
            {
                case "json": return Content(JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(count), _jsonSetting), "application/json");

                case "xml":
                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    doc.AppendChild(docNode);

                    XmlElement data = (XmlElement)doc.AppendChild(doc.CreateElement("data"));

                   
                    foreach (DataPoint DataPoint in _dataPoints)
                    {
                        XmlElement dataPointNode = doc.CreateElement("point");
                        XmlNode xNode = doc.CreateElement("x");
                        xNode.AppendChild(doc.CreateTextNode(DataPoint.X.ToString()));
                        dataPointNode.AppendChild(xNode);
                        XmlNode yNode = doc.CreateElement("y");
                        yNode.AppendChild(doc.CreateTextNode(DataPoint.Y.ToString()));
                        dataPointNode.AppendChild(yNode);
                        data.AppendChild(dataPointNode);

                    }

                    var xmlString = doc.OuterXml;

                    return Content(xmlString, "text/xml");

                case "csv":
                    string csv = "";

                    foreach (DataPoint DataPoint in _dataPoints)
                        csv += DataPoint.X.ToString() + "," + DataPoint.Y.ToString() + "\n";

                    return Content(csv);

                default: return Content(JsonConvert.SerializeObject(DataService.GetRandomDataForNumericAxis(count), _jsonSetting), "application/json"); ;
            }
            
        }

        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

        private static List<DataPoint> _dataPoints = new List<DataPoint>();

    }
}