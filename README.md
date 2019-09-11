# CitiesWeather

Run Steps:

1. Clone the repo

2. Build and run CityCoordinatesAPI with IIS Express for a locally served API at port 44354.

3. Create a config.js file with your Dark Sky secret key, like this:
```
var config = {
    SECRET_KEY: '[YOUR_SECRET_KEY]'
}
```
4. Open View.html for a simple UI built with Vue.js + Axios.

xUnit testing project included with the CityCoordinatesAPI solution with 20 tests.