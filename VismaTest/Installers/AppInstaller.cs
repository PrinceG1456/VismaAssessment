using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VismaTest.WebApi.Installers
{
    public class AppInstaller : IInstaller
    {
        public IServiceCollection InstallServices(IServiceCollection services)
        {

            services.AddControllers();
               

          

            return services;
        }
    }
}
