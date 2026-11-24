namespace TowerDemo;

public class FeuerUpgrade : TurmDekorator
{
    public FeuerUpgrade(ITurm turm) : base(turm) { }

    public override string Beschreibung => base.Beschreibung + " + Feuer";
    public override int Schaden => base.Schaden + 5;
    public override int Kosten => base.Kosten + 60;
}
