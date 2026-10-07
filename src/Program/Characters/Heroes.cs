using System;
namespace Ucu.Poo.RoleplayGame;

public abstract class Heroes : Characters
{
    // Propiedad pública de lectura para consultar los VP
    public int VictoryPoints { get; private set; } = 0;

    public Heroes(string name) : base(name)
    {
    }

    Heroes hero = new Heroes("Hero"); // Instancia de héroe para asignar puntos de victoria al derrotar enemigos

    public void GainVP(int vp)
    {
        if (vp > 0)
        {
            this.VictoryPoints += vp;
        }
    }
}