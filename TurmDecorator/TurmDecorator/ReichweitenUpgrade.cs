namespace TowerDemo;

/// <summary>Fernglas: +2 Felder Reichweite.</summary>
public class ReichweitenUpgrade : TurmDekorator
{
    public ReichweitenUpgrade(ITurm turm) : base(turm) { }

    public override string Beschreibung => base.Beschreibung + " + Reichweite";
    public override double Reichweite => base.Reichweite + 2.0;
    public override int Kosten => base.Kosten + 40;
}
