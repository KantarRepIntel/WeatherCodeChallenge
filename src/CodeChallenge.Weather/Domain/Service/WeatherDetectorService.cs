using System;

namespace CodeChallenge.Weather.Domain.Service
{
    public class WeatherDetectorService
    {
        public string GetWeather(SensorsWeather sensor)
        {
            // TODO: This is a simple example, just to pass the tests is incompleted.
            //       Here is where the candidate should complet the implementation.

            if (sensor.TemperatureInCelsius == 20)
            {
                return "is having a good weather";
            }

            throw new NotImplementedException();
        }
    }
}
