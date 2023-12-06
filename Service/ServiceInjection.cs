using FormationGarneauApiNetCore.FlightPriceNamespace.Services;
using Microsoft.Extensions.DependencyInjection;
using Service.FlightPriceNamespace.Interfaces;
using Service.FlightPriceNamespace.Services;
using Service.Lotterie.Services;
using Service.Ricardo;
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
            services.AddScoped<IFlightPrice, FlightPriceService>();
            services.AddScoped<ILotterieService, LotterieService>();
            services.AddScoped<IRicardoService, RicardoService>();
           
        }
    }
}
