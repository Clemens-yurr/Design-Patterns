using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StrategyPattern
{
    public class Athlet
    {
        public string Name { get; }
        public int Maxpuls { get; }
        public int Ruhepuls { get; }
        public int Schwellenpuls { get; }

        public Athlet(string name, int maxpuls, int ruhepuls, int schwellenpuls)
        {
            Name = name;
            Maxpuls = maxpuls;
            Ruhepuls = ruhepuls;
            Schwellenpuls = schwellenpuls;
        }
    }
}
