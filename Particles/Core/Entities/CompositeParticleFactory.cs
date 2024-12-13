namespace Core.Entities;

public static class CompositeParticleFactory
{
    public static CompositeParticle CreateProton()
    {
        return new CompositeParticle
        {
            Name = "Próton",
            ConstituentParticles = 
            [
                FundamentalParticleFactory.CreateRedUpQuark(),
                FundamentalParticleFactory.CreateBlueUpQuark(),
                FundamentalParticleFactory.CreateGreenDownQuark()
            ],
            ElectricCharge = 1,
            Spin = 0.5,
            Mass = 938.27e6,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }
}