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
            #region Swagger配置
            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo {
                    Version = "v1.1.0",
                    Title = "Incorrect.Core API",
                    Description = "框架接口文档说明",

                    //TermsOfService = new System.Uri("en"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Elica",
                        Email = "1663535827@qq.com",
                        Url = new System.Uri("mailto:1663535827@qq.com")
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense {
                        Name = "版权许可"
                    }
                }); ;
                // 为 Swagger JSON and UI设置xml文档注释路径
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                var xmlPath = Path.Combine(basePath, "Incorrect.Core.xml");
                c.IncludeXmlComments(xmlPath);
            });
            #endregion
            #region 数据库授权连接
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
            #region swagger 中间件
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
