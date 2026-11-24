using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Trainingsplaner
    {
        private IPulsStrategie _strategie;

        public Trainingsplaner(IPulsStrategie strategie)
        {
            _strategie = strategie;
        }

        public void SetStrategie(IPulsStrategie strategie)
        {
            _strategie = strategie;
        }

        public int Zielpuls(Athlet athlet, double intensitaet)
        {
            return _strategie.BerechneZielpuls(athlet, intensitaet);
        }

        public string GetStrategieName() => _strategie.GetName();

        public string GetFormel() => _strategie.GetFormel();

        public string GetRechenweg(Athlet athlet, double intensitaet)
        {
            return _strategie.GetRechenweg(athlet, intensitaet);
        }
    }
}
