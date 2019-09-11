using CityCoordinatesAPI.Models;
using System.Collections.Generic;

namespace CityCoordinatesAPI.Interfaces
{
    public interface ICityStore
    {
        List<City> GetCities();
    }
}
