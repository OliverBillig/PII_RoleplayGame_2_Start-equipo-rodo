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
}