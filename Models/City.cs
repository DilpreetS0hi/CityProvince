using System.Collections.Generic;

namespace CityProvince.Models
{
    public class City
    {
        public int CityId{ get; set; }
        
        public string CityName{ get; set; }
        
        public int Population{ get; set; }

        //foreign keys
        public string ProvinceName{ get; set; }
        public Province Province{ get; set; }

        public static List<City> GetCities () {
            List<City> cities = new List<City> () {
            new City {
            CityId = 1,
            CityName = "Surrey",
            Population = 300000,
            ProvinceName = "British Columbia",
            },
            new City {
            CityId = 2,
            CityName = "Edmonton",
            Population = 1800000,
            ProvinceName = "Alberta",
            },
            new City {
            CityId = 3,
            CityName = "Brantford",
            Population = 800000,
            ProvinceName = "Ontario",
            },
        };

        return cities;
        }

    }
}