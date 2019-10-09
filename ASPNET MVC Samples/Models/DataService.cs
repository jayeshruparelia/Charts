using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

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
            string value = File.ReadAllText(@"D:\Harshal\Hasckathon\ASPNET MVC Samples\App_Data\Food_Utilization_All.json");
            //var val = string.Empty;
            //
            //var constr = "Data Source = dbgreen.database.windows.net; Initial Catalog = hackathon2019; Persist Security Info = True; User ID = gradmin; Password = Password@1";"
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    SqlCommand command = new SqlCommand("select top 10 asof_date as x, wasted as y from item_utilisation for json auto", con);
            //    command.Connection.Open();
            //    val = command.ExecuteNonQuery();
            //}

            JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            var arr = JsonConvert.DeserializeObject<FoodItem[]>(value, _jsonSetting);

            switch (chartType)
            {
                case ChartType.Daily:
                case ChartType.Monthly:
                    _newDataPoints = GetChartData(arr);
                    break;
                case ChartType.Comparision:
                    _newDataPoints = GetComparisionDataPoints(arr);
                    break;
                default:
                    break;
            }

            //for (int i = 0; i < count; i++)
            //{
            //    y = y + (random.Next(0, 20) - 10);

            //    _dataPoints.Add(new DataPoint(i, y));
            //}

            return _newDataPoints;
        }

        private static ChartData GetComparisionDataPoints(FoodItem[] arr)
        {
            throw new NotImplementedException();
        }

        //private static ChartData GetChartData(FoodData arr)
        private static ChartData GetChartData(FoodItem[] arr)
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