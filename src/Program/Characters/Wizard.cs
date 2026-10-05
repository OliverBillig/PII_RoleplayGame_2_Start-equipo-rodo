namespace Ucu.Poo.RoleplayGame;

public class Wizard : Heroes, ICharacter
{
    public Wizard(string name) : base(name)
    {
    }
    public SpellsBook SpellsBook { get; set; }
    public Staff Staff { get; set; }
    
    public int AttackValue
    {
        get { return SpellsBook.AttackValue + Staff.AttackValue; }
    }

    public int DefenseValue
    {
        get { return SpellsBook.DefenseValue + Staff.DefenseValue; }
    }

    public void ReceiveAttack(int damage)
    {
        if (this.DefenseValue < damage)
        {
            this.health -= damage - this.DefenseValue;
        }
    }
}
