using minAPIs.Extensions;

var title = "dev";
var version = "v5" ;

var builder = WebApplication.CreateBuilder(args).
  IocContainer(title,version)
  .Build()
  .AppMiddleware($"{title} {version}");
