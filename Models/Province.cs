using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityProvince.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode{ get; set; }
        
        public string ProvinceName{ get; set; }
        
        public List<City> Cities{ get; set; }

        public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>
        {
            new Province() {
                ProvinceCode="BC",
                ProvinceName = "British Columbia",
                
            },
            new Province() {
                ProvinceCode="AB",
                ProvinceName = "Alberta",
                
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName = "Ontario",
            
            },
        };

        return provinces;
    }

        
    }
}