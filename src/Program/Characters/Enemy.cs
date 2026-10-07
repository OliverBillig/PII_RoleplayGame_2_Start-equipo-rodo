using System;

namespace Ucu.Poo.RoleplayGame;

public abstract class Enemy : Characters
{
    // Esta es la propiedad que le falta o que debe ser pública:
    public int VictoryPoints { get; protected set; }

    public Enemy(string name, int victoryPoints) : base(name)
    {
        this.VictoryPoints = victoryPoints;
    }

    public int OnDefeatedBy(Heroes hero)
    {
        hero.GainVP(this.VictoryPoints);
        this.VictoryPoints = 0;
        return this.VictoryPoints;
    }
}