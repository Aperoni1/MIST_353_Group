using System.ComponentModel.DataAnnotations;

namespace MIST_353_Group_API.Entities
{
    public class Weather
    {
        [Key]
        public int WeatherID { get; set; }
        public int LocationID { get; set; } // Added Foreign Key
        public Location Location { get; set; }
        public int FireWarningID { get; set; }  // Added Foreign Key
        public FireWarning FireWarning { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal WindSpeed { get; set; }
        public string WeatherCondition { get; set; }
    }
}
