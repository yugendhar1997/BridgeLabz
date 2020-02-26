// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.Interface;
using Manager.Manager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model;
using Repository;
using Repository.Interface;
using Repository.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace Fundoo
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
            services.AddTransient<UserManager<UserModels>>();
            services.AddTransient<UserContext>();
            services.AddTransient<AppSetting>();
            services.Configure<AppSetting>(this.Configuration.GetSection("AppSettings"));
            services.AddDbContext<UserContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));
            var appSettingsSection = this.Configuration.GetSection("AppSettings");
            services.Configure<AppSetting>(appSettingsSection);

            services.AddMvc();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            //// Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info 
                {
                    Title = "FUNDOO NOTES API",
                    Version = "v1" ,
                    Description="ASP.NET core WEB API"
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccount, AccountManager>();
            services.AddTransient<INotesRepository, NotesRepository>();
            services.AddTransient<INotes, NotesManager>();
            services.AddTransient<ILabel, LabelManager>();
            services.AddTransient<ILabelRepository, LabelRepository>();
        }

        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FUNDOO NOTE API");
                });
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
