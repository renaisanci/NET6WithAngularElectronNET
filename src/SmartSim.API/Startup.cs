using ElectronNET.API;
using ElectronNET.API.Entities;

namespace SmartSim.API
{
    public class Startup
    {


        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public void ConfigurationService(IServiceCollection services)
        {

            services.AddControllersWithViews();
        }


        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            if (HybridSupport.IsElectronActive)
            {
                CreateWindow();
            }
        }
        private async void CreateWindow()
        {

            var browserWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
            {
                Width = 800,
                Height = 600,
                Show = false
            });

            browserWindow.OnReadyToShow += () =>
            {
                browserWindow.Show();
                browserWindow.Maximize();
            };
            browserWindow.OnClose += () =>
            {
                Electron.App.Quit();
            };
        }

    }
}
