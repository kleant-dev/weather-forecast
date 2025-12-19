namespace WeatherForecastApi.Data;

public class WeatherForecastData
{
    public static List<WeatherForecast> Data = [
            new WeatherForecast { City = "New York", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), TemperatureC = 12, Summary = "Chilly" },
            new WeatherForecast { City = "London", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), TemperatureC = 8, Summary = "Rainy" },
            new WeatherForecast { City = "Tokyo", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), TemperatureC = 18, Summary = "Mild" },
            new WeatherForecast { City = "Sydney", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), TemperatureC = 26, Summary = "Sunny" },
            new WeatherForecast { City = "Paris", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), TemperatureC = 15, Summary = "Cloudy" },
            new WeatherForecast { City = "Dubai", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(6)), TemperatureC = 38, Summary = "Hot" },
            new WeatherForecast { City = "Berlin", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(7)), TemperatureC = 4, Summary = "Freezing" },
            new WeatherForecast { City = "Mumbai", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(8)), TemperatureC = 31, Summary = "Humid" },
            new WeatherForecast { City = "Rio de Janeiro", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(9)), TemperatureC = 29, Summary = "Balmy" },
            new WeatherForecast { City = "Cairo", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(10)), TemperatureC = 22, Summary = "Clear" }
    ];
    
}