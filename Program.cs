using Microsoft.OpenApi.Models;
using minAPIs.Extensions;

var title = "dev";
var version = "v5" ;

var builder = WebApplication.CreateBuilder(args).
  IocContainer(title,version)
  .Build()
  .AppMiddleware($"{title} {version}");

/* Add services to the container.
builder.Services.AddControllers();
Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",new OpenApiInfo {Title="dev", Version="v4"});
});*/

//builder.IocContainer(title,version)
//   .Build()
//   .AppMiddleware($"{title} {version}");
//var app = builder.Build();

//app.AppMiddleware(@"{title} {version}");
//builder.Build()
//    .AppMiddleware($"{title} {version}");

/* Configure the HTTP request pipeline.s
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json","dev v4"));
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();*/
