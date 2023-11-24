using Interfaces;

namespace Domain 
{
    public class WeatherData : IObservable
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers) {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementsChanged() {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public float GetTemperature() {
            return temperature;
        }

        public float GetHumidity() {
            return humidity;
        }

        public float GetPressure() {
            return pressure;
        }
    }
}

