using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Karvonen : IPulsStrategie
    {
        public int BerechneZielpuls(Athlet athlet, double intensitaet)
        {
            int reserve = athlet.Maxpuls - athlet.Ruhepuls;
            return Runden(athlet.Ruhepuls + reserve * intensitaet);
        }

        public string GetName() => "Karvonen";

        public string GetFormel() => "Ruhepuls + (Maxpuls − Ruhepuls) × Intensität";

        public string GetRechenweg(Athlet athlet, double intensitaet)
        {
            int reserve = athlet.Maxpuls - athlet.Ruhepuls;
            double anteil = reserve * intensitaet;
            return $"{athlet.Ruhepuls} + ({athlet.Maxpuls} − {athlet.Ruhepuls}) × {intensitaet}"
                 + $" = {athlet.Ruhepuls} + {anteil} = {athlet.Ruhepuls + anteil}";
        }

        private static int Runden(double wert) =>
            (int)Math.Round(wert, MidpointRounding.AwayFromZero);
    }
}
