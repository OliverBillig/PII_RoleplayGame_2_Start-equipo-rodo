using System;
namespace Ucu.Poo.RoleplayGame;

public class Enemy : Characters
{
    private int victoryPoints = new Random().Next(1, 11);
    public Enemy(string name) : base(name)
    {
    }

    public override int Health
    {
        get { return this.health; }
        
        {
            if (value < 0)
            {
                this.health = 0;
                Console.WriteLine($"Enemy {this.Name} has been defeated! The player gains {this.victoryPoints} victory points.");
                
            }
            else
            {
                this.health = value;
            }
        }
    }
}