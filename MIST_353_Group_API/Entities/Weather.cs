using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIST_353_Group_API.Entities
{
    public class Weather
    {
        [Key]
        public int WeatherID { get; set; }
        public int LocationID { get; set; } // Foreign Key
        public Location Location { get; set; }

        // Navigation property for FireWarnings 
        public ICollection<FireWarning> FireWarnings { get; set; }

        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal WindSpeed { get; set; }
        public string WeatherCondition { get; set; }

        // NotMapped property for ParkStatus
        [NotMapped]
        public string ParkStatus
        {
            get
            {
                if (WeatherCondition == "Extreme" || (FireWarnings != null && FireWarnings.Any(fw => fw.Status == "Active")))
                {
                    return "Closed";
                }
                else
                {
                    return "Open";
                }
            }
        }
    }
}
