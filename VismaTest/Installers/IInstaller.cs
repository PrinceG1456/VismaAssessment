using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VismaTest.WebApi.Installers
{
    public interface IInstaller
    {
        IServiceCollection InstallServices(IServiceCollection services);
    }
}
