using Core.Entities;

namespace Core.Services;

public interface IParticleService
{
    List<FundamentalParticle> GetParticles();
}