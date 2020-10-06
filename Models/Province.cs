using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4_1.Models
{
    public class Province
    {
        [Key]
        [Display (Name="Province Code")]
        public string ProvinceCode { get; set; }

        [Display(Name = "Province Name")]
        public string ProvinceName { get; set; }
         
        public List<City> Cities { get; set; }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>
            {
                new Province()
                {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia",
                },
                new Province()
                {
                    ProvinceCode="AB",
                    ProvinceName="Alberta",
                },
                new Province()
                {
                    ProvinceCode="MB",
                    ProvinceName="Manitoba"
                }
            };
            return provinces;
        }
    }
}
