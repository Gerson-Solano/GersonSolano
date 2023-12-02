using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesSystem.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
//using SalesSystem.DAL.implementation;
//using SalesSystem.DAL.interfaces;

//using SalesSystem.BLL.implementation;
//using SalesSystem.BLL.interfaces;
//28-43

namespace SalesSystem.IOC
{
    public static class Dependence
    {
        public static void InjectDependence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("StringConexion"));
            });
        }
    }
}
