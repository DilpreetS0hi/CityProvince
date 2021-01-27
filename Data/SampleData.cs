using CityProvince.Models;
using Microsoft.EntityFrameworkCore;

namespace CityProvince.Data
{
    public static class SampleData {
  // this is an extension method to the ModelBuilder class
        public static void Seed (this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Province>().HasData (
                Province.GetProvinces ()
            );
            modelBuilder.Entity<City>().HasData (
                City.GetCities ()
            );
        }
}
}