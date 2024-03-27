using System.ComponentModel.DataAnnotations;

namespace MIST_353_Group_API.Entities
{
    public class FireWarning
    {
        [Key]
        public int FireWarningID { get; set; } 
        public int LocationID { get; set; }
        public int WeatherID { get; set; }  // Added Foreign Key
        public Weather Weather { get; set; }    
        public DateTime TimeLastUpdated { get; set; }
        public DateTime TimeFirstReported { get; set; }
        public string Status { get; set; }

    }
}
