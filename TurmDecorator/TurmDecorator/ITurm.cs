namespace TowerDemo;


public interface ITurm
{
    string Beschreibung { get; }
    int Schaden { get; }          // Schaden pro Schuss
    double Reichweite { get; }    // in Feldern
    double Feuerrate { get; }     // Schüsse pro Sekunde
    int Verlangsamung { get; }    // in Prozent
    int Kosten { get; }           // Gesamtkosten in Münzen
}
