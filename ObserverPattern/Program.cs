using Domain;

var weatherData = new WeatherData();
var currentDisplay = new CurrentConditionsDisplay(weatherData);

weatherData.RegisterObserver(currentDisplay);

weatherData.SetMeasurements(80,65,30.4f);
weatherData.SetMeasurements(82,70,29.2f);

weatherData.RemoveObserver(currentDisplay);

weatherData.SetMeasurements(78,90,29.2f);
