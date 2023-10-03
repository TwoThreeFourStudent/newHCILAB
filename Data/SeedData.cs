using assig2.Models;

namespace  assig2.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {    // 2
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
                new Province() {  // 3
                ProvinceCode="QC",
                ProvinceName="Quebec",
            },

        };

            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
            new City {
                CityID = 1,
                Population = 10,
                CityName = "Vancouver",
                ProvinceCode = "BC"
            },
            new City {
                CityID = 2,
                Population = 9,
                CityName = "Surrey",
                 ProvinceCode = "BC"
            },
            new City {
                CityID = 3,
                Population = 10,
                CityName = "Calgary",
                ProvinceCode = "AB"
            },
            new City {
                CityID = 4,
                Population = 11,
                CityName = "Red Deer",
                ProvinceCode = "AB"
            },
                new City {
                CityID = 5,
                Population = 15,
                CityName = "Quebec City",
                ProvinceCode = "QC"
            },
            new City {
                CityID = 6,
                Population = 17,
                CityName = "Montreal",
                ProvinceCode = "QC"
            },

        };

            return cities;
        }
    }
}