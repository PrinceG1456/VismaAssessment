using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VismaTest.Service.IService;
using VismaTest.Service.Service;

namespace VismaTest.WebApi.Installers
{
    public class ServiceInstaller:IInstaller
    {
        public IServiceCollection InstallServices(IServiceCollection services)
        {
            services.AddScoped<IInvoiceService, InvoiceService>();

            return services;
        }
    }
}
