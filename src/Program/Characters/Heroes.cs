using System;
namespace Ucu.Poo.RoleplayGame;

public class Heroes
{
    public string Name { get; private set; }
    public int health = 100;
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
    public Heroes(string name)
    {
        Name = name;
    }
    public void Cure()
    {
        health = 100; // Assuming full health is 100
    }
}