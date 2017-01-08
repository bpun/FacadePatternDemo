using System;
using FacadePatternDemo.Interface;
using FacadePatternDemo.Models;
using FacadePatternDemo.Services;

namespace FacadePatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
             const string zipCode = "SeattleZipCode";
 
            // GeoLocService geoLookupService = new GeoLocService();
        
            // string city = geoLookupService.GetCityForZipCode(zipCode);
            // string state = geoLookupService.GetStateForZipCode(zipCode);
            // Coordinates coords = geoLookupService.GetCoordinatesForZipCode(zipCode);
        
            // WeatherService weatherService = new WeatherService();
            // double farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
        
            // MetricConverterService metricConverter = new MetricConverterService();
            // double celcius = metricConverter.FarenheitToCelcius(farenheit);
        
 
            ITemperatureService temperatureService = new TemperatureService();
            LocalTemperature localTemp = temperatureService.GetTemperature(zipCode);
        
            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",
                                localTemp.Farenheit.ToString("F1"),
                                localTemp.Celcius.ToString("F1"),
                                localTemp.City,
                                localTemp.State);
        
            Console.ReadKey();
        }
    }
}
