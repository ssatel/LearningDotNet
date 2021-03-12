using AutoMapper;
using Begin5.Application;
using Begin5.Application.Interface;
using Begin5.Entidades;
using Begin5.Infra;
using Begin5.Models;
using Begin5.Repository;
using Begin5.Repository.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5
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
            var mySqlConnection = "server=localhost;database=new_schema;user=root;password=ml@Satel2014"; //= Configuration.GetConnectionString("DeltaBridgeConnection");
            
            services.AddDbContext<Context>(option => option.UseMySQL(mySqlConnection));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Begin5", Version = "v1" });
            });

            var configuration = new MapperConfiguration(cfg => 
            { 
                cfg.CreateMap<Usuario, UsuarioResponseDTO>().ReverseMap();
                cfg.CreateMap<UsuarioRequestDTO, UsuarioResponseDTO>().ReverseMap();
                cfg.CreateMap<Conta, ContaRequestDTO>().ReverseMap();
                cfg.CreateMap<Conta, ContaRequestDTO>().ReverseMap();

            });

            IMapper mapper = configuration.CreateMapper();

            services.AddSingleton(mapper);

            services.AddScoped<IContaApplication, ContaApplication>();
            services.AddScoped<IUsuarioApplication, UsuarioApplication>();
            services.AddScoped<IContaRepository, ContaRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Begin5 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        
        
    }
}
