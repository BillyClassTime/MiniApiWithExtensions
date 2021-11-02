namespace minAPIs.Extensions
{
    public static class AppExtensions
    {
        public static WebApplication AppMiddleware(this WebApplication app,string swaggerDefinition)
        {

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", swaggerDefinition));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}