using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CWTechnicalAssignment.Data;

namespace CWTechnicalAssignment
{
    public partial class Startup
    {
        private void ConfigureCustomServices(IServiceCollection services)
        {
            //Use Static Hello World Repository
            services.AddTransient<IHelloWorldRepository, StaticHelloWorldRepository>();

            //Use File Hello World Repository
            //services.AddTransient<IHelloWorldRepository, FileHelloWorldRepository>();

            //Use File Hello World Repository
            //services.AddTransient<IHelloWorldRepository, DataBaseHelloWorldRepository>();

        }
    }
}
