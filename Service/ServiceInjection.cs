using FormationGarneauApiNetCore.FlightPriceNamespace.Services;
using Microsoft.Extensions.DependencyInjection;
using Service.FlightPriceNamespace.Interfaces;
using Service.FlightPriceNamespace.Services;
using Service.Lotterie.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class ServiceInjection
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IFlightPrice, FlightServiceCore>();
            services.AddScoped<ILotterieService, LotterieService>();
        }
    }
}
