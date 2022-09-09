using ElectronNET.API;
using SmartSim.API;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseElectron(args);

var startup = new Startup(builder.Configuration);
startup.ConfigurationService(builder.Services);

var app = builder.Build();


startup.Configure(app, app.Environment);
app.Run();
