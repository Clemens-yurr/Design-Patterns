using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IPulsStrategie
    {
        int BerechneZielpuls(Athlet athlet, double intensitaet);
        string GetName();
        string GetFormel();
        string GetRechenweg(Athlet athlet, double intensitaet);
    }
}
