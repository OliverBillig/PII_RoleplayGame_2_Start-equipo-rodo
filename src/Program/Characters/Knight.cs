namespace Ucu.Poo.RoleplayGame;

public class Knight : Characters, ICharacter
{
    public Knight(string name) : base(name)
    {
        base.AttackValue = 5;
    }

    public Sword Sword { get; set; }
    public Shield Shield { get; set; }
    public Armor Armor { get; set; }

    public new int AttackValue
    {
        get { return base.AttackValue + Sword.AttackValue; }
    }

    public new int DefenseValue
    {
        get { return base.DefenseValue + Armor.DefenseValue + Shield.DefenseValue; }
    }
}