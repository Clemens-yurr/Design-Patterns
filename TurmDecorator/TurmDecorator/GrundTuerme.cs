namespace TowerDemo;

public class GrundTurm : ITurm
{
    public string Beschreibung => "Grundturm";
    public int Schaden => 10;
    public double Reichweite => 4.0;
    public double Feuerrate => 1.0;
    public int Verlangsamung => 0;
    public int Kosten => 100;
}
