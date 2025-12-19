namespace WeatherForecastApi.Data;

public class Extremes
{
    public string Name { get; } = "Extremes";
    public double Hottest { get; set; }
    public double Coldest { get; set; }
}