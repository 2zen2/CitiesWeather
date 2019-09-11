using CityCoordinatesAPI.Interfaces;
using CityCoordinatesAPI.Models;
using System.Collections.Generic;


namespace CityCoordinatesAPI.Implementations
{
    public class CityStore : ICityStore
    {
        public List<City> GetCities()
        {
            List<City> cities = new List<City>();

            City city0 = new City()
            {
                Name = "Phoenix",
                StateProvince = "Arizona",
                Country = "United States of America",
                Latitude = 33.448376,
                Longitude = -112.074036
            };

            City city1 = new City()
            {
                Name = "Raleigh",
                StateProvince = "North Carolina",
                Country = "United States of America",
                Latitude = 35.779591,
                Longitude = -78.638176
            };

            City city2 = new City()
            {
                Name = "Saint John",
                StateProvince = "New Brunswick",
                Country = "Canada",
                Latitude = 45.273315,
                Longitude = -66.063309,
            };

            City city3 = new City()
            {
                Name = "San Diego",
                StateProvince = "Arizona",
                Country = "United States of America",
                Latitude = 32.715736,
                Longitude = -117.161087
            };

            City city4 = new City()
            {
                Name = "Yellowknife",
                StateProvince = "Northwest Territories",
                Country = "Canada",
                Latitude = 62.453972,
                Longitude = -114.371788
            };

            City city5 = new City()
            {
                Name = "Vancouver",
                StateProvince = "Northwest Territories",
                Country = "Canada",
                Latitude = 49.282730,
                Longitude = -123.120735
            };

            City city6 = new City()
            {
                Name = "Seattle",
                StateProvince = "Washington",
                Country = "United States of America",
                Latitude = 47.6062,
                Longitude = -122.3321
            };

            cities.Add(city0);
            cities.Add(city1);
            cities.Add(city2);
            cities.Add(city3);
            cities.Add(city4);
            cities.Add(city5);
            cities.Add(city6);            

            return cities;
        }
    }
}
