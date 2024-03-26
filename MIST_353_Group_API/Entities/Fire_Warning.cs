using System.ComponentModel.DataAnnotations;

namespace MIST_353_Group_API.Entities
{
    public class Fire_Warning
    {
        [Key]
        public int WarningID { get; set; }
        public DateTime TimeLastUpdated { get; set; }
        public DateTime TimeFirstReported { get; set; }
        public string Status { get; set; }
        public int LocationID { get; set; }
    }
}
