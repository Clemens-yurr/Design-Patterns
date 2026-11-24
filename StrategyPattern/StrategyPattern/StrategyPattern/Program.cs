using System.Globalization;
using System.Text;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;                 // damit × und − richtig angezeigt werden
            CultureInfo.CurrentCulture = new CultureInfo("de-AT");  // Komma statt Punkt bei Kommazahlen

            Athlet toni = new Athlet("Toni", 190, 50, 170);
            Trainingsplaner plan = new Trainingsplaner(new ProzentMaxpuls());
            double intensitaet = 0.75;

            IPulsStrategie[] strategien =
            {
            new ProzentMaxpuls(),
            new Karvonen(),
            new Laktatschwelle()
        };

            // Teil 1: Athletendaten
            Console.WriteLine("==============================================");
            Console.WriteLine("              PULSZONEN-RECHNER");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Athlet:          {toni.Name}");
            Console.WriteLine($"Maxpuls:         {toni.Maxpuls} bpm");
            Console.WriteLine($"Ruhepuls:        {toni.Ruhepuls} bpm");
            Console.WriteLine($"Schwellenpuls:   {toni.Schwellenpuls} bpm");
            Console.WriteLine($"Intensität:      {intensitaet * 100} %");
            Console.WriteLine();

            // Teil 2: Jede Strategie im Detail
            int nummer = 1;
            foreach (IPulsStrategie strategie in strategien)
            {
                plan.SetStrategie(strategie);

                Console.WriteLine($"--- Strategie {nummer}: {plan.GetStrategieName()} ---");
                Console.WriteLine($"Formel:      {plan.GetFormel()}");
                Console.WriteLine($"Rechenweg:   {plan.GetRechenweg(toni, intensitaet)}");
                Console.WriteLine($"Ergebnis:    {plan.Zielpuls(toni, intensitaet)} bpm");
                Console.WriteLine();
                nummer++;
            }

            // Teil 3: Vergleichstabelle
            int[] prozente = { 60, 70, 80, 90 };

            Console.WriteLine("==============================================");
            Console.WriteLine("      VERGLEICH VERSCHIEDENER INTENSITÄTEN");
            Console.WriteLine("==============================================");

            Console.Write($"{"Strategie",-16}");
            foreach (int p in prozente)
            {
                Console.Write($"{p + " %",8}");
            }
            Console.WriteLine();

            foreach (IPulsStrategie strategie in strategien)
            {
                plan.SetStrategie(strategie);
                Console.Write($"{plan.GetStrategieName(),-16}");
                foreach (int p in prozente)
                {
                    Console.Write($"{plan.Zielpuls(toni, p / 100.0),8}");
                }
                Console.WriteLine();
            }
        }
    }
}