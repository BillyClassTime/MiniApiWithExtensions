using minAPIs.Extensions;
var title = "dev";
var version = "v7" ;
var builder = WebApplication.CreateBuilder(args)
    .IocContainer(title, version)
    .Build()
    .AppMiddleware($"{title} {version}")
    .GetMethods();
builder.Run();
    
