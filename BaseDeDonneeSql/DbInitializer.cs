using BaseDeDonneeSql.FlightPriceNameSpace;
using BaseDeDonneeSql.Lotterie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql
{
    public static class DbInitializer
    {
       
        public static void Initialize(DbContextGarneau context)
        {
            var fligthPrince = new FlightPrice[]
            {
                new FlightPrice { Price = 200.5f, Arrival = "Paris", Depart = "New York" },
                new FlightPrice { Price = 150.0f, Arrival = "London", Depart = "Tokyo" },
                new FlightPrice { Price = 300.75f, Arrival = "Berlin", Depart = "Sydney" },
                new FlightPrice { Price = 180.25f, Arrival = "Rome", Depart = "Beijing" },
                new FlightPrice { Price = 250.0f, Arrival = "Madrid", Depart = "Seoul" },
                new FlightPrice { Price = 175.5f, Arrival = "Amsterdam", Depart = "Los Angeles" },
                new FlightPrice { Price = 220.0f, Arrival = "Dubai", Depart = "San Francisco" },
                // Ajouter 4 objets avec le même départ
                new FlightPrice { Price = 190.0f, Arrival = "Barcelona", Depart = "New York" },
                new FlightPrice { Price = 210.5f, Arrival = "Athens", Depart = "New York" },
                new FlightPrice { Price = 180.0f, Arrival = "Lisbon", Depart = "New York" },
                new FlightPrice { Price = 200.0f, Arrival = "Paris", Depart = "New York" },
                // Ajouter 4 objets avec la même arrivée
                new FlightPrice { Price = 240.0f, Arrival = "London", Depart = "Tokyo" },
                new FlightPrice { Price = 260.5f, Arrival = "London", Depart = "Beijing" },
                new FlightPrice { Price = 220.0f, Arrival = "London", Depart = "Sydney" },
                new FlightPrice { Price = 200.0f, Arrival = "London", Depart = "Seoul" },
            };

            var listNumero = new BouleNumero[56];
            for (int i = 0; i < 56; i++)
            {
                listNumero[i]=new BouleNumero { Numero = i + 1 };
            }
            BilletLotterieEntity[] billets = new BilletLotterieEntity[20];

            // Remplir le tableau avec des entités ayant des valeurs aléatoires
            for (int i = 0; i < billets.Length; i++)
            {
                billets[i] = new BilletLotterieEntity
                {                   
                    PourcentageReussite = Outil.GetRandomDouble(),
                    TempsQuIlFaisait = Outil.GetRandomWeather(),
                    MontantRemporter = Outil.GetRandomUInt(),
                    NombreDeGagnant = Outil.GetRandomUInt(),
                    Numéros = new List<BouleNumero>(){
                        listNumero[Outil.GetRandomUIntListNumero()], listNumero[Outil.GetRandomUIntListNumero()],
                        listNumero[Outil.GetRandomUIntListNumero()], listNumero[Outil.GetRandomUIntListNumero()],
                        listNumero[Outil.GetRandomUIntListNumero()], listNumero[Outil.GetRandomUIntListNumero()]
                    }
                };
            }
            context.ListeBoulesNumero.AddRange(listNumero);
            context.FlightPrices.AddRange(fligthPrince);
            context.BilletLotteries.AddRange(billets);
            context.SaveChanges();
        }
    }
}
