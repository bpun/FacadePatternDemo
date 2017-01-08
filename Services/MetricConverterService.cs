namespace FacadePatternDemo.Services
{
    public class MetricConverterService
    {
        public double FarenheitToCelcius(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
