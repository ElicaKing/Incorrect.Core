using Autofac;
using Incorrect.Core.Common;
using Incorrect.Core.Common.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace Incorrect.Core
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
            services.AddControllers();
            //services.AddMvc();
            #region Swagger����
            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo {
                    Version = "v1.1.0",
                    Title = "Incorrect.Core API",
                    Description = "��ܽӿ��ĵ�˵��",

                    //TermsOfService = new System.Uri("en"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Elica",
                        Email = "1663535827@qq.com",
                        Url = new System.Uri("mailto:1663535827@qq.com")
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense {
                        Name = "��Ȩ���"
                    }
                }); ;
                // Ϊ Swagger JSON and UI����xml�ĵ�ע��·��
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//��ȡӦ�ó�������Ŀ¼�����ԣ����ܹ���Ŀ¼Ӱ�죬������ô˷�����ȡ·����
                var xmlPath = Path.Combine(basePath, "Incorrect.Core.xml");
                c.IncludeXmlComments(xmlPath);
            });
            #endregion
            #region ���ݿ���Ȩ����
            services.AddDbContext<MyDbContext>(options=> {
                
                options.UseSqlServer(Appsettings.app(new string[] { "SqlServer", "IncorrectDB" }).ObjToString());
            });
            services.AddMvc();

            #endregion

        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;
            var service = Path.Combine(basePath, "Incorrect.Core.Service.dll");
            var repository = Path.Combine(basePath, "Incorrect.Core.Respository.dll");

            builder.RegisterAssemblyTypes(Assembly.LoadFrom(service))
                      .AsImplementedInterfaces()
                      .InstancePerDependency();

            builder.RegisterAssemblyTypes(Assembly.LoadFrom(repository))
                   .AsImplementedInterfaces()
                   .InstancePerDependency();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            #region swagger �м��
            app.UseSwagger();
            app.UseSwaggerUI(c=> {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","Incorrect Api V1");
                c.RoutePrefix = string.Empty;
            });
            #endregion
            app.UseStaticFiles();
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
