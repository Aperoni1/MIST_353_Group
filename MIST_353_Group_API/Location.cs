using System.ComponentModel.DataAnnotations;

namespace MIST_353_Group_API
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Long { get; set; }
        public string Lat { get; set; }
        public string ParkName { get; set; }
    }
}
