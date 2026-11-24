using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Laktatschwelle : IPulsStrategie
    {
        public int BerechneZielpuls(Athlet athlet, double intensitaet)
        {
            return Runden(athlet.Schwellenpuls * intensitaet);
        }

        public string GetName() => "Laktatschwelle";

        public string GetFormel() => "Schwellenpuls × Intensität";

        public string GetRechenweg(Athlet athlet, double intensitaet)
        {
            return $"{athlet.Schwellenpuls} × {intensitaet} = {athlet.Schwellenpuls * intensitaet}";
        }

        private static int Runden(double wert) =>
            (int)Math.Round(wert, MidpointRounding.AwayFromZero);
    }
}
