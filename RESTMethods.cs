namespace minAPIs.Extensions
{
    public static class RESTMethods
    {
        public static WebApplication GetMethods(this WebApplication app)
        {
            app.GetWeather();
            return app;
        }
        internal record Weather(DateTime Data, int TemperatureC, string? Summary)
        {
            public int TemperaturaF => 32 + (int)(TemperatureC / 0.5556);
        }

        private static WebApplication GetWeather(this WebApplication app)
        {
            var summaries = new[]
                {
                    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
                };
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
            return app;
        }
    }
}
