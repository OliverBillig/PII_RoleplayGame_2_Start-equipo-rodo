namespace Ucu.Poo.RoleplayGame;

public class Archer : Characters, ICharacter
{
    public Archer(string name) : base(name)
    {
    }
    public Bow Bow { get; set; }
    public Helmet Helmet { get; set; }

    public new int AttackValue
    {
        get { return base.AttackValue + Bow.AttackValue; }
    }

    public new int DefenseValue
    {
        get { return base.DefenseValue + Helmet.DefenseValue; }
    }
}