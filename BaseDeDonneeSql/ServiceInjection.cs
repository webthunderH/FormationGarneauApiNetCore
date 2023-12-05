using BaseDeDonneeSql.FlightPriceNameSpace;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql
{
    public static class ServiceInjection
    {
        public static void AddGarneauDatabase(this IServiceCollection services)
        {
            services.AddDbContext<DbContextGarneau>(option=>option.UseSqlServer("Server=Ezo1023\\SQLEXPRESS;Database=FormationGarneau;Trusted_Connection=True;"));
          
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IFlightPriceRepository, FlightPriceRepository>();
        }
    }
}
