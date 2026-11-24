using System.Text;
using TowerDemo;


internal static class Program
{
    private static void Main()
    {

        Ueberschrift("1) Grundturm");
        ITurm turm = new GrundTurm();
        Zeige(turm);

        Ueberschrift("2) Upgrades zur Laufzeit kaufen (Hülle um Hülle)");
        turm = new FeuerUpgrade(turm);
        Zeige(turm);
        turm = new FrostUpgrade(turm);
        Zeige(turm);
        turm = new ReichweitenUpgrade(turm);
        Zeige(turm);

        Ueberschrift("3) Die Reihenfolge ist wichtig");
        ITurm erstFeuer = new DoppelSchadenUpgrade(new FeuerUpgrade(new GrundTurm()));   // (10 + 5) * 2
        ITurm erstDoppel = new FeuerUpgrade(new DoppelSchadenUpgrade(new GrundTurm()));  // 10 * 2 + 5
        Zeige(erstFeuer);
        Zeige(erstDoppel);

        Ueberschrift("4) Dasselbe Upgrade mehrfach");
        ITurm dreiMalFeuer = new FeuerUpgrade(new FeuerUpgrade(new FeuerUpgrade(new GrundTurm())));
        Zeige(dreiMalFeuer);

        Ueberschrift("5) Anderer Grundturm, gleiche Upgrades");
        ITurm scharfschuetze = new FrostUpgrade(new ReichweitenUpgrade(new ScharfschuetzenTurm()));
        Zeige(scharfschuetze);

        Ueberschrift("6) Kampf-Simulation: Gegner mit 120 Leben");
        Kampf(new GrundTurm(), 120);
        Kampf(turm, 120);
        Kampf(erstFeuer, 120);
        Kampf(scharfschuetze, 120);
    }

    private static void Zeige(ITurm turm)
    {
        Console.WriteLine(
            $"{turm.Beschreibung,-52} " +
            $"Schaden {turm.Schaden,3} | " +
            $"Reichweite {turm.Reichweite:F1} | " +
            $"Feuerrate {turm.Feuerrate:F1}/s | " +
            $"Slow {turm.Verlangsamung,3} % | " +
            $"{turm.Kosten} Münzen");
    }

    private static void Kampf(ITurm turm, int gegnerLeben)
    {
        int schuesse = (int)Math.Ceiling((double)gegnerLeben / turm.Schaden);
        double sekunden = schuesse / turm.Feuerrate;
        Console.WriteLine($"{turm.Beschreibung,-52} braucht {schuesse} Schüsse = {sekunden:F1} s");
    }

    private static void Ueberschrift(string text)
    {
        Console.WriteLine();
        Console.WriteLine(text);
        Console.WriteLine(new string('-', text.Length));
    }
}
