namespace Ucu.Poo.RoleplayGame;

public class Dwarf : Characters, ICharacter
{
    public Dwarf(string name) : base(name)
    {
    }
    public Axe Axe { get; set; }
    public Shield Shield { get; set; }
    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get { return Axe.AttackValue; }
    }

    public int DefenseValue
    {
        get { return Shield.DefenseValue + Helmet.DefenseValue; }
    }
    public void ReceiveAttack(int damage)
    {
        if (this.DefenseValue < damage)
        {
            this.health -= damage - this.DefenseValue;
        }
    }
}