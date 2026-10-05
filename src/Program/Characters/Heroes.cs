using System;
namespace Ucu.Poo.RoleplayGame;

public abstract class Heroes : Characters
{
    private int victoryPoints = 0;
    public Heroes(string name) : base(name)
    {
    }

    public void GainVP(int vp)
    {
        this.victoryPoints += vp;
    }
}