using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First_Lab.Models.Places
{
    public class DummyData
    {
        public static List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {

                new Province() { provinceCode = "BC", provinceName = "British Columiba", cities = new List<City>() {
                        new City() { cityID = 1, cityName = "Vancouver", population = 2463431 },
                        new City() { cityID = 2, cityName = "Burnaby", population = 232755 },
                        new City() { cityID = 3, cityName = "Delta", population = 99863 },
                    }
                },

                new Province() { provinceCode = "ON", provinceName = "Ontario", cities = new List<City>() {
                        new City() { cityID = 4, cityName = "Toronto", population = 6254000 },
                        new City() { cityID = 5, cityName = "Brampton", population = 593638 },
                        new City() { cityID = 6, cityName = "Scarborough", population = 632098 },
                    }
                },

                new Province() { provinceCode = "AB", provinceName = "Alberta", cities = new List<City>() {
                        new City() { cityID = 7, cityName = "Calgary", population = 1239220 },
                        new City() { cityID = 8, cityName = "Edmonton", population = 930000 },
                        new City() { cityID = 9, cityName = "Red Deer", population = 100418 },
                    }
                },

            };

            return provinces;
        }

    }
}