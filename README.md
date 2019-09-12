# CitiesWeather

Run Steps:

1. Clone the repo

2. Inside the repo, create a config.js file with your Dark Sky secret key, like this:
```
var config = {
    SECRET_KEY: '[YOUR_SECRET_KEY]'
}
```
3. Make sure you have .NET Core SDK 2.2 installed on your machine. You can find them here: https://dotnet.microsoft.com/download/dotnet-core/2.2

4. Build and run CityCoordinatesAPI with IIS Express for a locally served API at port 44354.

5. Open View.html for a simple UI built with Vue.js + Axios.

xUnit testing project included with the CityCoordinatesAPI solution with 20 tests.
