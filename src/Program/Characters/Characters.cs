using System;
namespace Ucu.Poo.RoleplayGame;

public abstract class Characters
{
    public int health = 100;
    
    // Cambiado 'protected' a 'public' para permitir la lectura en Encounter
    public int AttackValue { get; set; } 
    public int DefenseValue { get; set; }  
    public string Name { get; private set; }

    public virtual int Health
    {
        get { return this.health; }
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

    public Characters(string name)
    {
        Name = name;
    }

    public void Cure()
    {
        health = 100;
    }

    public void ReceiveAttack(int damage)
    {
        if (this.DefenseValue < damage)
        {
            this.health -= damage - this.DefenseValue;
        }
    }
}