using Interfaces;

namespace Domain 
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private WeatherData weatherData;
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: temperature {temperature} degress, humidity {humidity}%");
        }

        public void Update()
        {
            temperature = weatherData.GetTemperature();
            humidity = weatherData.GetHumidity();
            Display();
        }
    }
}