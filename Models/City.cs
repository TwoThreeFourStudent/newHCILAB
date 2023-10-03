using System.ComponentModel.DataAnnotations.Schema;

namespace assig2.Models{
        public class City
    {   
 
        public int? CityID { get; set; }
        public string? CityName { get; set; }
        public int? Population { get; set; }
        public string? ProvinceCode { get; set; }

        

        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
    }
}