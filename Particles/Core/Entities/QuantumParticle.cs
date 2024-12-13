namespace Core.Entities;

public abstract class QuantumParticle
{
    public virtual string Name { get; set; }
    public virtual double Mass { get; set; }
    public virtual double ElectricCharge { get; set; }
    public virtual double Spin { get; set; }
    public virtual FundamentalInteraction[] FundamentalInteractions { get; set; } = [];
    public virtual ColorCharge ColorCharge { get; set; }
    public virtual ParticleFamily FamilyOrGeneration { get; set; }
    public virtual bool IsAntiparticle { get; set; }
    public virtual bool IsOppositeParticle { get; set; }
}