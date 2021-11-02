using minAPIs.Extensions;
var title = "dev";
var version = "v9" ;
var builder = WebApplication.CreateBuilder(args);
builder
    .IocContainer(title, version)
    .Build()
    .AppMiddleware($"{title} {version}")
    .Run();