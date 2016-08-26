﻿using InvSys.Gateway.Core.GraphQLTest;
using InvSys.Shared.Api.Startup;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace InvSys.Gateway.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInvSysLocalization();
            services.AddInvSysConfiguration(Configuration);
            services.AddMvc().AddDataAnnotationsLocalization();
            services.AddInvSysAuthorization();

            services.AddTransient<IStarWarsGraphQL, StarWarsGraphQL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseInvSysLocalization(Configuration);
            app.UseInvSysLogger(Configuration, loggerFactory);
            app.UseInvSysOAuth(Configuration);
            app.UseMvc();
        }
    }
}
