using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Cache.CacheManager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();


builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
                     .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
                     .AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration)
                .AddCacheManager(options=> options.WithDictionaryHandle());

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

await app.UseOcelot();

app.Run();
