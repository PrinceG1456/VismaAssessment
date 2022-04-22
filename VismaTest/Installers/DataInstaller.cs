using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VismaTest.DAL.Store;
using VismaTest.Service.IService;
using VismaTest.Service.Service;

namespace VismaTest.WebApi.Installers
{
    public class DataInstaller : IInstaller
    {
        public IServiceCollection InstallServices(IServiceCollection services)
        {
            services.AddSingleton<IDataContext, DataContext>();

            return services;
        }
    }
}
