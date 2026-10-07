using System;
namespace Ucu.Poo.RoleplayGame;

public class Orc : Enemy
{
    public Orc(string name) : base(name)
    {
        base.AttackValue = 5;
    }
}