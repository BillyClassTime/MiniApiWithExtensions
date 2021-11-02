using Microsoft.OpenApi.Models;

namespace minAPIs.Extensions
{
    public static class BuilderExtension
    {
        public static WebApplicationBuilder IocContainer(this WebApplicationBuilder builder,string title,string version)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title=title,Version=version });
            });
            return builder;
        }
    }
}