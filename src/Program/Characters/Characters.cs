using System;
namespace Ucu.Poo.RoleplayGame;

public class Characters
{
    public int health = 100;
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
        health = 100; // Assuming full health is 100
    }
}