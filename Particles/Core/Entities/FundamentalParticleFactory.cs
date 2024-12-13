namespace Core.Entities;

public static class FundamentalParticleFactory
{
    public static FundamentalParticle CreateBoson()
    {
        return new FundamentalParticle
        {
            Name = "Boson",
            Mass = 0.0,
            ElectricCharge = 0.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Electromagnetic ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }
    
    public static FundamentalParticle CreateBosonW()
    {
        return new FundamentalParticle
        {
            Name = "Boson W",
            Mass = 80.379,
            ElectricCharge = 1.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateBosonZ()
    {
        return new FundamentalParticle
        {
            Name = "Boson Z",
            Mass = 91.1876,
            ElectricCharge = 0.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateHiggsBoson()
    {
        return new FundamentalParticle
        {
            Name = "Higgs Boson",
            Mass = 125.10,
            ElectricCharge = 0.0,
            Spin = 0.0,
            FundamentalInteractions = [ FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateFermion()
    {
        return new FundamentalParticle
        {
            Name = "Férmion",
            Mass = 9.10938356e-31,
            ElectricCharge = -1.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }
    
    public static FundamentalParticle CreateRedUpQuark()
    {
        return new FundamentalParticle
        {
            Name = "Up Quark",
            Mass = 2.3e-3,
            ElectricCharge = 2.0 / 3.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.Red,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateBlueUpQuark()
    {
        return new FundamentalParticle
        {
            Name = "Up Quark",
            Mass = 2.3e-3,
            ElectricCharge = 2.0 / 3.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.Blue,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateGreenUpQuark()
    {
        return new FundamentalParticle
        {
            Name = "Up Quark",
            Mass = 2.3e-3,
            ElectricCharge = 2.0 / 3.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.Green,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateRedDownQuark()
    {
        return new FundamentalParticle
        {
            Name = "Down Quark",
            Mass = 4.8e-3,
            ElectricCharge = -1.0 / 3.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.Red,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateBlueDownQuark()
    {
        return new FundamentalParticle
        {
            Name = "Down Quark",
            Mass = 4.8e-3,
            ElectricCharge = -1.0 / 3.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.Blue,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateGreenDownQuark()
    {
        return new FundamentalParticle
        {
            Name = "Down Quark",
            Mass = 4.8e-3,
            ElectricCharge = -1.0 / 3.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Strong, FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.Green,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateLepton()
    {
        return new FundamentalParticle
        {
            Name = "Lepton",
            Mass = 0.51099895e-3,
            ElectricCharge = -1.0,
            Spin = 0.5,
            FundamentalInteractions = [ FundamentalInteraction.Electromagnetic, FundamentalInteraction.Weak ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.First,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreatePhoton()
    {
        return new FundamentalParticle
        {
            Name = "Photon",
            Mass = 0.0,
            ElectricCharge = 0.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Electromagnetic ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateRedGluon()
    {
        return new FundamentalParticle
        {
            Name = "Gluon",
            Mass = 0.0,
            ElectricCharge = 0.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Strong ],
            ColorCharge = ColorCharge.Red,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }
    
    public static FundamentalParticle CreateGreenGluon()
    {
        return new FundamentalParticle
        {
            Name = "Gluon",
            Mass = 0.0,
            ElectricCharge = 0.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Strong ],
            ColorCharge = ColorCharge.Green,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }
    
    public static FundamentalParticle CreateBlueGluon()
    {
        return new FundamentalParticle
        {
            Name = "Gluon",
            Mass = 0.0,
            ElectricCharge = 0.0,
            Spin = 1.0,
            FundamentalInteractions = [ FundamentalInteraction.Strong ],
            ColorCharge = ColorCharge.Blue,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }

    public static FundamentalParticle CreateGraviton()
    {
        return new FundamentalParticle
        {
            Name = "Graviton",
            Mass = 0.0,
            ElectricCharge = 0.0,
            Spin = 2.0,
            FundamentalInteractions = [ FundamentalInteraction.Gravitational ],
            ColorCharge = ColorCharge.None,
            FamilyOrGeneration = ParticleFamily.None,
            IsAntiparticle = false,
            IsOppositeParticle = false
        };
    }
}