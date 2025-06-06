using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json",optional:false,reloadOnChange:true);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOcelot(builder.Configuration)
    .AddCacheManager(x => {
        x.WithDictionaryHandle();
    });
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.MapControllers();
app.UseOcelot().Wait();

app.Run();