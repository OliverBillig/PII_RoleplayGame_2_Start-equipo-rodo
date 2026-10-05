namespace Ucu.Poo.RoleplayGame;

public class Knight : Characters, ICharacter
{
    public Knight(string name) : base(name)
    {
    }

    public Sword Sword { get; set; }
    public Shield Shield { get; set; }
    public Armor Armor { get; set; }

    public int AttackValue
    {
        get { return Sword.AttackValue; }
    }

    public int DefenseValue
    {
        get { return Armor.DefenseValue + Shield.DefenseValue; }
    }

    public void ReceiveAttack(int damage)
    {
        if (this.DefenseValue < damage)
        {
            this.health -= damage - this.DefenseValue;
        }
        if (this.health <= 0)
        {
            Console.WriteLine($"{this.Name} has been defeated!");
        }
    }
}