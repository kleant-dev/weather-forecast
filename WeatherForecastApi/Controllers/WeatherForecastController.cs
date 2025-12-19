using Microsoft.AspNetCore.Mvc;
using WeatherForecastApi.Data;

namespace WeatherForecastApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("/")]
    public ActionResult<IEnumerable<WeatherForecast>> Get()
    {
        List<WeatherForecast> weatherForecast = WeatherForecastData.Data;
        return Ok(weatherForecast);
    }

    [HttpGet("/{city}")]
    public ActionResult<WeatherForecast> Get(string city)
    {
        WeatherForecast? weatherForecast = WeatherForecastData.Data.FirstOrDefault(w => w.City == city);
        if (weatherForecast == null)
        {
            return NotFound();
        }

        return Ok(weatherForecast);
    }

    [HttpPost("/")]
    public ActionResult<WeatherForecast> Post([FromBody] WeatherForecast weatherForecast)
    {
        WeatherForecastData.Data.Add(weatherForecast);
        return CreatedAtAction(nameof(Get), new { id = weatherForecast.City }, weatherForecast);
    }

    [HttpGet("/analytics/average")]
    public ActionResult<Average> GetAverage()
    {
        Average average = new Average() {Value = WeatherForecastData.Data.Average(w => w.TemperatureC) };
        return Ok(average);
    }

    [HttpGet("/analytics/extremes")]
    public ActionResult<Extremes> GetExtremes()
    {
        double hottest = WeatherForecastData.Data.Select(w => w.TemperatureC).Max();
        double coldest = WeatherForecastData.Data.Select(w => w.TemperatureC).Min();

        Extremes extremes = new Extremes()
        {
            Hottest = hottest,
            Coldest = coldest
        };
        
        return Ok(extremes);
    }
}