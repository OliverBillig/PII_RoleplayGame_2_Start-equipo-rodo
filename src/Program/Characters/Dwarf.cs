namespace Ucu.Poo.RoleplayGame;

public class Dwarf : Characters, ICharacter
{
    public Dwarf(string name) : base(name)
    {
    }
    public Axe Axe { get; set; }
    public Shield Shield { get; set; }
    public Helmet Helmet { get; set; }

    public new int AttackValue
    {
        get { return base.AttackValue + Axe.AttackValue; }
    }

    public new int DefenseValue
    {
        get { return base.DefenseValue + Shield.DefenseValue + Helmet.DefenseValue; }
    }
    
}