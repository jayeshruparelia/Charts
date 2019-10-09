namespace ASPNET_MVC_Samples.Models
{
    public class FoodItem
    {
        public FoodItem()
        {

        }
        public double waste_percent { get; set; }
        public string asof_date { get; set; }
        public double wasted { get; set; }
        public double unused { get; set; }
        public double acquired { get; set; }
        public double unused_percent { get; set; }
    }
}