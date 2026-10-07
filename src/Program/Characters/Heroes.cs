using System;
namespace Ucu.Poo.RoleplayGame;

public abstract class Heroes : Characters
{
    public int VictoryPoints { get; private set; } = 0;

    public Heroes(string name) : base(name)
    {
    }

    public void GainVP(int vp)
    {
        if (vp > 0)
        {
            this.VictoryPoints += vp;
        }
    }
}