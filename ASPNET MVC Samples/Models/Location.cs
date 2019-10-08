using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_Samples.Models
{
    public class Location
    {
        public Guid LocationID { get; set; }

        /// <summary>
        /// Office Name eg. Magarpatta-Pune(-India-APAC).
        /// </summary>
        public string Office { get; set; }

        public string Region { get; set; }

        public string  Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

    }
}