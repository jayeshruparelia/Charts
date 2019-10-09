using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_Samples.Models
{
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
}