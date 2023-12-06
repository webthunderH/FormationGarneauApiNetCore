using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql
{
    internal static class Outil
    {
        internal static double GetRandomDouble()
        {
            Random random = new Random();
            return random.NextDouble();
        }

        // Fonction pour obtenir un entier sans signe (uint) aléatoire
        internal static uint GetRandomUInt()
        {
            Random random = new Random();
            return (uint)random.Next();
        }
        internal static uint GetRandomUIntListNumero()
        {
            Random random = new Random();
            return (uint)random.Next(1,56);
        }
        // Fonction pour obtenir une météo aléatoire
        internal static string GetRandomWeather()
        {
            string[] weatherOptions = { "Ensoleillé", "Nuageux", "Pluvieux", "Neigeux" };
            Random random = new Random();
            int index = random.Next(weatherOptions.Length);
            return weatherOptions[index];
        }
    }
}
