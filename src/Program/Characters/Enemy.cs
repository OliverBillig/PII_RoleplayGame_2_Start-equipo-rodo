using System;
namespace Ucu.Poo.RoleplayGame;

public abstract class Enemy : Characters
{
    public int victoryPoints = new Random().Next(1, 11);
    public Enemy(string name) : base(name)
    {
    }

    public new int Health
    {
        get { return this.health; }
        set
        {
            if (value < 0)
            {
                this.health = 0;
                Console.WriteLine($"Enemy {this.Name} has been defeated! The player gains {this.victoryPoints} victory points.");
                this.victoryPoints = 0;
            }
            else
            {
                this.health = value;
            }
        }
    }


    

}