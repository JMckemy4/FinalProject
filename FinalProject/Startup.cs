using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace FinalProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            
            services.AddHttpClient("RapidAPI1", client =>
            {
                client.BaseAddress = new Uri("https://weed-strain1.p.rapidapi.com/?ordering=-strain");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");
            });

            
            services.AddHttpClient("RapidAPI2", client =>
            {
                client.BaseAddress = new Uri("https://weed-strain1.p.rapidapi.com/?ordering=strain");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");
            });

            services.AddHttpClient("RapidAPI3", client =>
            {
                client.BaseAddress = new Uri("https://weed-strain1.p.rapidapi.com/?difficulty=medium");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");
            });

            services.AddHttpClient("RapidAPI4", client =>
            {
                client.BaseAddress = new Uri("https://weed-strain1.p.rapidapi.com/?strainType=Hybrid");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");
            });

            services.AddHttpClient("RapidAPI5", client =>
            {
                client.BaseAddress = new Uri("https://weed-strain1.p.rapidapi.com/?strainType=Hybrid");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");
            });

            
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=WeedStrains}/{action=Index}/{id?}");
            });
        }
    }
}