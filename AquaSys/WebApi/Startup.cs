using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Microsoft.EntityFrameworkCore;
using ClassLibraries.Models;
using ClassLibraries.Data.Context;
using ClassLibraries.Repositorios;


namespace WebApi
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
            //services.AddDbContext<DataContext>(options => options.UseSqlite(Configuration.GetConnectionString("SqlServer")));
            services.AddDbContext<Context>(opt => opt.UseInMemoryDatabase("StoreDB"));

            services.AddMvc();
            services.AddScoped<IPessoa.cs, Pessoa.cs>();
            services.AddScoped<IDono.cs, Dono.cs>();
            services.AddScoped<IFazenda.cs, Fazenda.cs>();
            services.AddScoped<IManeijo.cs, Maneijo.cs>();
            services.AddScoped<IDespesca.cs, Despesca.cs>();
            services.AddScoped<ITrabalhador.cs, Trabalhador.cs>();
            services.AddScoped<ITrabaladorSetor.cs, TrabaladorSetor.cs>();
            services.AddScoped<ISetor.cs, Setor.cs>();
            services.AddScoped<ISensor.cs, Sensor.cs>();
            services.AddScoped<IEndereco.cs, Endereco.cs>();
            services.AddScoped<IViveiro.cs, Viveiro.cs>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }    
    }
}
