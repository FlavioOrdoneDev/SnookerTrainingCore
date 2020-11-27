using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using SnookerTrainingCore.Infra.Contexto;
using SnookerTrainingCore.Infra.Repositorios;
using SnookerTrainingCore.Infra.SeedingService;

namespace SnookerTrainingCore.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SnookerContexto>(opcoes => opcoes.UseSqlServer(Configuration.GetConnectionString("Conexao")));


            services.AddScoped<SnookerContexto, SnookerContexto>();
            services.AddScoped<SeedingService, SeedingService>();

            services.AddTransient<ICategoriaServico, CategoriaServico>();
            services.AddTransient<IRotinaServico, RotinaServico>();
            services.AddTransient<ITreinoServico, TreinoServico>();
            services.AddTransient<IPontuacaoServico, PontuacaoServico>();
            services.AddTransient<IResultadoServico, ResultadoServico>();

            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IRotinaRepositorio, RotinaRepositorio>();
            services.AddTransient<ITreinoRepositorio, TreinoRepositorio>();
            services.AddTransient<IPontuacaoRepositorio, PontuacaoRepositorio>();
            services.AddTransient<IResultadoRepositorio, ResultadoRepositorio>();


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Categoria}/{action=Index}/{id?}");
            });
        }
    }
}
