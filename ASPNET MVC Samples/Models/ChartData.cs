using System.Collections.Generic;

namespace ASPNET_MVC_Samples.Models
{
    public class ChartData
    {
        public ChartDataSeries _dataPoint1, _dataPoint2, _dataPoint3;

        public ChartData(ChartDataSeries dataPoint1, ChartDataSeries dataPoint2, ChartDataSeries dataPoint3)
        {
            _dataPoint1 = dataPoint1;
            _dataPoint2 = dataPoint2;
            _dataPoint3 = dataPoint3;
        }
    }

    public class ChartDataSeries
    {
        WasteType _legend;
        public List<ChartDataPoint> TypeOfWasteData { get; set; }

        public ChartDataSeries(WasteType legend)
        {
            _legend = legend;
            TypeOfWasteData = new List<ChartDataPoint>();
        }
    }
}