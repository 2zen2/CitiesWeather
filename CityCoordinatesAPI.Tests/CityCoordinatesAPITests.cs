using CityCoordinatesAPI.Controllers;
using CityCoordinatesAPI.Implementations;
using CityCoordinatesAPI.Interfaces;
using CityCoordinatesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace CityCoordinatesAPI.Tests
{
    public class CityCoordinatesApiTests
    {
        //Setup for the tests.
        CityController _cityController;
        ICityStore _cityStore;

        //Tests class constructor
        public CityCoordinatesApiTests()
        {
            _cityStore = new CityStore();
            _cityController = new CityController(_cityStore);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var okResult = _cityController.Get();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllCities()
        {
            var okResult = _cityController.Get().Result as OkObjectResult;

            var cities = Assert.IsType<List<City>>(okResult.Value);
            Assert.Equal(7, cities.Count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void GetById_WhenCalledWithKnownId_ReturnsOkResult(int id)
        {
            var okResult = _cityController.Get(id);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Theory]
        [InlineData(8)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        [InlineData(-1)]
        public void GetById_WhenCalledWithUnknownId_ReturnsNotFoundResult(int id)
        {
            var notFoundResult = _cityController.Get(id);

            Assert.IsType<NotFoundObjectResult>(notFoundResult.Result);
        }

        [Theory]
        [InlineData(0, "Phoenix")]
        [InlineData(1, "Raleigh")]
        [InlineData(2, "Saint John")]
        [InlineData(3, "San Diego")]
        [InlineData(4, "Yellowknife")]
        [InlineData(5, "Vancouver")]
        [InlineData(6, "Seattle")]
        public void GetById_WhenCalled_ReturnsCorrectCity(int id, string expectedCityName)
        {
            var okResult = _cityController.Get(id).Result as OkObjectResult;

            var city = Assert.IsType<City>(okResult.Value);
            Assert.Equal(expectedCityName, city.Name);
        }
    }
}
