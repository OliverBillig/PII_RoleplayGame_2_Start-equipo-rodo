using System;

namespace Ucu.Poo.RoleplayGame;

public abstract class Character
{
    private int health = 100;
    public abstract int AttackValue { get; }
    public abstract int DefenseValue { get; }
    public string Name { get; set; }

    protected Character(string name)
    {
        this.Name = name;
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            if (value < 0)
            {
                this.health = 0;
            }
            else
            {
                this.health = value;
            }
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
}