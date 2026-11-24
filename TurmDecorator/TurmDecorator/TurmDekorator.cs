namespace TowerDemo;

public abstract class TurmDekorator : ITurm
{
    private readonly ITurm _turm;

    protected TurmDekorator(ITurm turm)
    {
        _turm = turm;
    }

    public virtual string Beschreibung => _turm.Beschreibung;

    public virtual int Schaden => _turm.Schaden;
    public virtual double Reichweite => _turm.Reichweite;
    public virtual double Feuerrate => _turm.Feuerrate;
    public virtual int Verlangsamung => _turm.Verlangsamung;
    public virtual int Kosten => _turm.Kosten;
}
