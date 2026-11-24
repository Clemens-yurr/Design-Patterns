using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ProzentMaxpuls : IPulsStrategie
    {
        public int BerechneZielpuls(Athlet athlet, double intensitaet)
        {
            return Runden(athlet.Maxpuls * intensitaet);
        }

        public string GetName() => "% vom Maxpuls";

        public string GetFormel() => "Maxpuls × Intensität";

        public string GetRechenweg(Athlet athlet, double intensitaet)
        {
            return $"{athlet.Maxpuls} × {intensitaet} = {athlet.Maxpuls * intensitaet}";
        }

        private static int Runden(double wert) =>
            (int)Math.Round(wert, MidpointRounding.AwayFromZero);
    }
}


