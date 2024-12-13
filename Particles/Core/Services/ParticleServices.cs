using Core.Entities;

namespace Core.Services;

public class ParticleServices : IParticleService
{
    public List<FundamentalParticle> GetParticles()
    {
        return
        [
            FundamentalParticleFactory.CreateRedUpQuark()
        ];
    }
}