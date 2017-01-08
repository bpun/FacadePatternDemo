using FacadePatternDemo.Interface;
using FacadePatternDemo.Models;

namespace FacadePatternDemo.Services
{
    public class TemperatureService : ITemperatureService
    {
        readonly WeatherService _weatherService;
        readonly GeoLocService _geoLocService;
        readonly MetricConverterService _converter;
    
        public TemperatureService() : this(new WeatherService(), new GeoLocService(), new MetricConverterService())
        {}
    
        public TemperatureService(WeatherService weatherService, GeoLocService geoLocService, MetricConverterService converter)
        {
            _weatherService = weatherService;
            _converter = converter;
            _geoLocService = geoLocService;
        }
    
        public LocalTemperature GetTemperature(string zipCode)
        {
            Coordinates coords = _geoLocService.GetCoordinatesForZipCode(zipCode);
            string city = _geoLocService.GetCityForZipCode(zipCode);
            string state = _geoLocService.GetStateForZipCode(zipCode);
    
            double farenheit = _weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            double celcius = _converter.FarenheitToCelcius(farenheit);
    
            LocalTemperature localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celcius = celcius,
                City = city,
                State = state
            };
    
            return localTemperature;
        }
    }
}
