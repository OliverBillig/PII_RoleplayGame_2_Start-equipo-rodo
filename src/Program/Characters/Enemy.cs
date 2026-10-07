using System;
namespace Ucu.Poo.RoleplayGame;

public abstract class Enemy : Characters
{
    private int victoryPoints = new Random().Next(1, 11);
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
                this.GiveVp(hero); // Llama al método GiveVp para asignar los puntos de victoria al héroe.
                
            }
            else
            {
                this.health = value;
            }
        }
    }

    public void GiveVp (Heroes hero)
    {
        hero.GainVP(this.victoryPoints);
        this.victoryPoints = 0; // Resetea los puntos de victoria después de que el enemigo sea derrotado.
    }
}