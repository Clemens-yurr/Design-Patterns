namespace TowerDemo;

public class FrostUpgrade : TurmDekorator
{
    public FrostUpgrade(ITurm turm) : base(turm) { }

    public override string Beschreibung => base.Beschreibung + " + Frost";
    public override int Verlangsamung => Math.Min(100, base.Verlangsamung + 30);
    public override int Kosten => base.Kosten + 50;
}
