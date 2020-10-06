using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4_1.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Display (Name="City")]
        public string CityName { get; set; }
        public int Population { get; set; }

        [Display (Name ="Province Code")]
        public string ProvinceCode { get; set; }
        public Province Province { get; set; }
        
        public static List<City> GetCities()
        {
            List<City> cities = new List<City>
            {
                new City
                {
                    CityId= 1,
                    CityName= "Vancouver",
                    Population= 400,
                    ProvinceCode="BC"
                },
                new City
                {
                    CityId= 2,
                    CityName= "Surrey",
                    Population= 600,
                    ProvinceCode="BC"
                },
                new City
                {
                    CityId= 3,
                    CityName= "Maple Ridge",
                    Population= 200,
                    ProvinceCode="BC"
                },
                new City
                {
                    CityId= 4,
                    CityName= "Edmonton",
                    Population= 230,
                    ProvinceCode="AB"
                },
                new City
                {
                    CityId= 5,
                    CityName= "Calgary",
                    Population= 800,
                    ProvinceCode="AB"
                },
                new City
                {
                    CityId= 6,
                    CityName= "Red Deer",
                    Population= 1000,
                    ProvinceCode="AB"
                },
                new City
                {
                    CityId= 6,
                    CityName= "Red Deer",
                    Population= 1000,
                    ProvinceCode="AB"
                },
                new City
                {
                    CityId= 7,
                    CityName= "Winnipeg",
                    Population= 120,
                    ProvinceCode="MB"
                },
                new City
                {
                    CityId= 8,
                    CityName= "Selkirk",
                    Population= 827,
                    ProvinceCode="MB"
                },
                new City
                {
                    CityId= 9,
                    CityName= "Winkler",
                    Population= 423,
                    ProvinceCode="MB"
                },
            };

            return cities;
        }
    }
}
