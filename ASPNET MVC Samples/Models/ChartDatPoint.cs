using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_Samples.Models
{
    public class ChartTwoDataPoint
    {
        public double y { get; set; }
        public string x
        {
            get;
            set;
        }

        public ChartTwoDataPoint()
        {

        }
    }
        public class ChartDataPoint
    {
        public double y { get; set; }
        public string label
        {
            get;
            set;
        }

        public ChartDataPoint()
        {

        }

        public ChartDataPoint(double y, string label)
        {
            this.y = y;
            this.label = Convert.ToDateTime(label).ToShortDateString();
        }
    }

    public class PieDataPoint
    {
        public double y { get; set; }
        public string legendText { get; set; }
        public string label
        {
            get;
            set;
        }

        public PieDataPoint()
        {

        }

        public PieDataPoint(double y, string label)
        {
            this.y = y;
            this.label = Convert.ToDateTime(label).ToShortDateString();
        }

    }
}