using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacadePatternDemo.Models;

namespace FacadePatternDemo.Services
{
    public class GeoLocService
    {
       public Coordinates GetCoordinatesForZipCode(string zipCode)
        {
            return new Coordinates()
            {
                Latitude = 10,
                Longitude = 20
            };
        }
 
        public string GetCityForZipCode(string zipCode)
        {
            return "Seattle";
        }
    
        public string GetStateForZipCode(string zipCode)
        {
            return "Washington";
        }
    }
}
