using System.Collections.Generic;
using CityCoordinatesAPI.Interfaces;
using CityCoordinatesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityCoordinatesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICityStore _cityStore { get; set; }

        public CityController(ICityStore cityStore)
        {
            _cityStore = cityStore;
        }

        // GET api/city
        [HttpGet]
        public ActionResult<IEnumerable<City>> Get()
        {
            List<City> cities = _cityStore.GetCities();
            return Ok(cities);
        }

        // GET api/city/5
        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            List<City> cities = _cityStore.GetCities();
            if (id >= 0 && id < cities.Count)
            {
                return Ok(cities[id]);
            }
            else
            {
                return NotFound("City Not Found");
            }
        }
    }
}
