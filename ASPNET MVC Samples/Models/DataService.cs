using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ASPNET_MVC_Samples.Models
{
    public static class DataService
    {
        public static List<DataPoint> _dataPoints = new List<DataPoint>();

        public static List<DataPoint> GetRandomDataForNumericAxis(int count)
        {
            double y = 50;
            _dataPoints = new List<DataPoint>();


            for (int i = 0; i < count; i++)
            {
                y = y + (random.Next(0, 20) - 10);

                _dataPoints.Add(new DataPoint(i, y));
            }

            return _dataPoints;
        }

        public static List<DataPoint> GetRandomDataForCategoryAxis(int count)
        {
            double y = 50;
            DateTime dateTime = new DateTime(2006, 01, 1, 0, 0, 0);
            string label = "";

            _dataPoints = new List<DataPoint>();


            for (int i = 0; i < count; i++)
            {
                y = y + (random.Next(0, 20) - 10);
                label = dateTime.ToString("dd MMM");

                _dataPoints.Add(new DataPoint(y, label));
                dateTime = dateTime.AddDays(1);
            }

            return _dataPoints;
        }

        public static List<DataPoint> GetRandomDataForDateTimeAxis(int count)
        {
            double x = 0;
            double y = 50;

            var dateTime = new DateTime(2006, 01, 10, 0, 0, 0, DateTimeKind.Local);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            _dataPoints = new List<DataPoint>();


            for (int i = 0; i < count; i++)
            {
                y = y + (random.Next(0, 20) - 10);

                x = dateTime.ToUniversalTime().Subtract(epoch).TotalMilliseconds;


                _dataPoints.Add(new DataPoint(x, y));
                dateTime = dateTime.AddDays(1);
                //dateTime = dateTime.AddHours(1);
            }

            return _dataPoints;
        }

        private static Random random = new Random(DateTime.Now.Millisecond);

        private static ChartData _newDataPoints;

        public static ChartData GetChartData(string name, int locationId, DateTime fromDate, DateTime tooDate, ChartType chartType)
        {
            string URL = "https://dbgreen.azurewebsites.net/api/GetGraphData";
            string urlParameters = string.Empty;

            switch (chartType)
            {
                case ChartType.Daily:
                    urlParameters = "?code=Qi8NhmUpdFqwqmLUmjyQMCEw9%2FTEm5Xj6zq8YIsoa0oLlC7ENBs6tQ%3D%3D&name="+name+"&locationId=3&fromDate=2019-08-01&toDate=2019-08-30";                    
                    break;
                case ChartType.Monthly:
                    urlParameters = "?code=Qi8NhmUpdFqwqmLUmjyQMCEw9%2FTEm5Xj6zq8YIsoa0oLlC7ENBs6tQ%3D%3D&name="+name+"&locationId=3&fromDate=2018-08-01&toDate=2019-08-01";
                    break;
                case ChartType.ComparisionByCity:
                    urlParameters = "?code=Qi8NhmUpdFqwqmLUmjyQMCEw9%2FTEm5Xj6zq8YIsoa0oLlC7ENBs6tQ%3D%3D&name=" + name + "&locationId=3";
                    break;
                case ChartType.ComparisionByCountry:
                    urlParameters = "?code=Qi8NhmUpdFqwqmLUmjyQMCEw9%2FTEm5Xj6zq8YIsoa0oLlC7ENBs6tQ%3D%3D&name=" + name + "&locationId=3";
                    break;
            }

            _newDataPoints = GetChartDataFromService(URL, urlParameters);
            return _newDataPoints;
        }

        private static ChartData GetChartDataFromService(string URL, string urlParameters)
        {
            HttpClient client = new HttpClient();
            JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

            try
            {
                client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // List data response.
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObjects = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                    var val = JsonConvert.DeserializeObject<FoodItem[]>(dataObjects, _jsonSetting);

                    _newDataPoints = GetChartData(val);
                    return _newDataPoints;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
                client.Dispose();
            }
            return null;
        }

        private static ChartData GetComparisionDataPoints(FoodItem[] arr)
        {
            throw new NotImplementedException();
        }

        //private static ChartData GetChartData(FoodData arr)
        private static ChartData GetChartData(IEnumerable<FoodItem> arr)
        {
            ChartDataSeries Wasted = new ChartDataSeries(WasteType.Wasted);
            ChartDataSeries Unutilized = new ChartDataSeries(WasteType.Untilized);

            foreach (var fooditem in arr)
            {
                //Unutilized
                Unutilized.TypeOfWasteData.Add(
                    new ChartDataPoint
                    {
                        label = Convert.ToDateTime(fooditem.asof_date).ToShortDateString(),
                        y = fooditem.unused
                    });

                //wasted
                Wasted.TypeOfWasteData.Add(
                    new ChartDataPoint
                    {
                        label = Convert.ToDateTime(fooditem.asof_date).ToShortDateString(),
                        y = fooditem.wasted
                    });
            }

            return new ChartData(Wasted, Unutilized, null);
        }


    }
}