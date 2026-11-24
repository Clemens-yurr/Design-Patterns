namespace TowerDemo;

public class DoppelSchadenUpgrade : TurmDekorator
{
    public DoppelSchadenUpgrade(ITurm turm) : base(turm) { }

    public override string Beschreibung => base.Beschreibung + " + Doppelschaden";
    public override int Schaden => base.Schaden * 2;
    public override int Kosten => base.Kosten + 120;
}
