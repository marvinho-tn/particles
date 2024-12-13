namespace Core.Entities;

public class CompositeParticle : QuantumParticle
{
    public FundamentalParticle[] ConstituentParticles { get; set; } = [];
    public int BaryonNumber { get; set; }
    public double Lifetime { get; set; }
    public ParticleType ParticleType { get; set; }
    
    public double TotalSpin => (Spin + ConstituentParticles.Sum(particle => particle.Spin)) % 1;

    public override FundamentalInteraction[] FundamentalInteractions => ConstituentParticles.SelectMany(particle => particle.FundamentalInteractions).Distinct().ToArray();
    public override double ElectricCharge => ConstituentParticles.Sum(particle => particle.ElectricCharge);
    public override double Mass => ConstituentParticles.Sum(particle => particle.Mass) + 100.0;
}