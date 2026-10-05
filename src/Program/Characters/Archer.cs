namespace Ucu.Poo.RoleplayGame;

public class Archer : Characters, ICharacter
{
    public Archer(string name) : base(name)
    {
    }
    public Bow Bow { get; set; }
    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get { return Bow.AttackValue; }
    }

    public int DefenseValue
    {
        get { return Helmet.DefenseValue; }
    }

    public void ReceiveAttack(int damage)
    {
        if (this.DefenseValue < damage)
        {
            this.health -= damage - this.DefenseValue;
        }
    }
}