using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using AddressBook.DbContexts;
using System.Text;
using AddressBook.Services;
using AutoMapper;
using System;
using Newtonsoft.Json.Serialization;
using AddressBook.Repositories;
using AddressBook.Controllers;
using Microsoft.Extensions.Logging;
using AddressBook.Contracts.Services;
using AddressBook.Contracts.Repositories;

namespace AddressBook
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = Configuration["JwtSecret:Issuer"],
                       ValidAudience = Configuration["JwtSecret:Issuer"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecret:Key"]))
                   };
               });

            // parse request
            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
            }).AddNewtonsoftJson(setupAction =>
                 {
                     setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                 });

            ServiceProvider serviceProvider= services.BuildServiceProvider();
            ILogger<UserController> loggerAddressBook = serviceProvider.GetService<ILogger<UserController>>();
            ILogger<AuthController> loggerAuth = serviceProvider.GetService<ILogger<AuthController>>();
            ILogger<FileController> loggerFile = serviceProvider.GetService<ILogger<FileController>>();
            ILogger<MetadataController> loggerMetaData = serviceProvider.GetService<ILogger<MetadataController>>();
            ILogger<UserService> loggerService = serviceProvider.GetService<ILogger<UserService>>();
            services.AddSingleton(typeof(ILogger), loggerAddressBook);
            services.AddSingleton(typeof(ILogger), loggerAuth);
            services.AddSingleton(typeof(ILogger), loggerFile);
            services.AddSingleton(typeof(ILogger), loggerMetaData);
            services.AddSingleton(typeof(ILogger), loggerService);

            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "AddressBook Api",
                    Version = "v1"
                });
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<IAuthRepository,AuthRepository>();
            services.AddScoped<IMetaDataRepository, MetaDataRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService,AuthService>();
            services.AddScoped<IMetaDataService, MetaDataService>();
            services.AddScoped<IFileService, FileService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddDbContext<AddressBookContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
        }

        // configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appBuilder =>
                {
                    appBuilder.Run(async c =>
                    {
                        c.Response.StatusCode = 500;
                        await c.Response.WriteAsync("Internal server error");
                    });
                });
            }

            app.UseAuthentication();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AddressBook Api");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
