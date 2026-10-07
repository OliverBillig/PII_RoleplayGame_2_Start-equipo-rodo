using System;
namespace Ucu.Poo.RoleplayGame;

public class Wolf : Enemy
{
    public Wolf(string name) : base(name)
    {
        base.AttackValue = 2;
    }
}