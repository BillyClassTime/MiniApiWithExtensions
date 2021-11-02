using minAPIs.Extensions;
var title = "dev";
var version = "v6" ;

var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


var builder = WebApplication.CreateBuilder(args).
  IocContainer(title, version);
var app = builder.Build();
app.MapGet("/Weather", () =>
 {
     var forescast = Enumerable.Range(1, 5).Select(index =>
     new Weather
     (
         DateTime.Now.AddDays(index),
         Random.Shared.Next(-20, 55),
         summaries[Random.Shared.Next(summaries.Length)]
     ))
     .ToArray();
     return forescast;
 })
.WithName("GetWeather");
app.AppMiddleware($"{title} {version}");

internal record Weather (DateTime Data, int TemperatureC, string? Summary)
{
    public int TemperaturaF => 32 + (int)(TemperatureC / 0.5556);
}