using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SnookerTrainingCore.ApplicationService.AppServicos;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Templates;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Templates;
using SnookerTrainingCore.Infra.Contexto;
using SnookerTrainingCore.Infra.Repositorios;
using SnookerTrainingCore.Infra.Repositorios.Templates;

namespace SnookerTrainingCore.API
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

            services.AddTransient<ICategoriaAppServico, CategoriaAppServico>();
            services.AddTransient<IRotinaTemplateAppServico, RotinaTemplateAppServico>();
            services.AddTransient<ITreinoTemplateAppServico, TreinoTemplateAppServico>();
            services.AddTransient<IRotinaAppServico, RotinaAppServico>();

            services.AddTransient<ICategoriaServico, CategoriaServico>();
            services.AddTransient<IRotinaTemplateServico, RotinaTemplateServico>();
            services.AddTransient<ITreinoTemplateServico, TreinoTemplateServico>();
            services.AddTransient<IRotinaServico, RotinaServico>();
            services.AddTransient<ITreinoServico, TreinoServico>();
            services.AddTransient<IPontuacaoServico, PontuacaoServico>();
            services.AddTransient<IResultadoServico, ResultadoServico>();

            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IRotinaTemplateRepositorio, RotinaTemplateRepositorio>();
            services.AddTransient<ITreinoTemplateRepositorio, TreinoTemplateRepositorio>();
            services.AddTransient<IRotinaRepositorio, RotinaRepositorio>();
            services.AddTransient<ITreinoRepositorio, TreinoRepositorio>();
            services.AddTransient<IPontuacaoRepositorio, PontuacaoRepositorio>();
            services.AddTransient<IResultadoRepositorio, ResultadoRepositorio>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
