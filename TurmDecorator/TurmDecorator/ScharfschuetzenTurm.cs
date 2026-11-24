namespace TowerDemo;

public class ScharfschuetzenTurm : ITurm
{
    public string Beschreibung => "Scharfschützenturm";
    public int Schaden => 40;
    public double Reichweite => 9.0;
    public double Feuerrate => 0.4;
    public int Verlangsamung => 0;
    public int Kosten => 250;
}
