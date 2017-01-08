using FacadePatternDemo.Models;

namespace FacadePatternDemo.Interface
{
    interface ITemperatureService
    {
         LocalTemperature GetTemperature(string zipCode);
    }
}
