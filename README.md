# Dot Net 6.0 - Mini WebApi

With DotNet 6.0 and C# 10, you can create a mini webapi  and minimize them even more using extensions

In this guide you can reduce the creation of the WebApi following the next steps

## Creating the DotNet WebApi with C#

To do that you need install DotNet 6.0 SDK, when you had done this, you can review the dotnet version:
```powershell
dotnet --info
```

the answer must be same to this:

![](img/dotnet01.png)

The content of the new webapi files is similar to next list:

+ controllers
  + WeatherForecastController.cs
+ Program.cs
+ WeatherForecastController.cs

The files are describe like this:

```c#
// WeatherForecastController.cs 
using Microsoft.AspNetCore.Mvc;

namespace minAPIs.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
```





```
/// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

If we  run the application the result is like this:

![](img/dotnet02.png)

