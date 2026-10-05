namespace Ucu.Poo.RoleplayGame;

public class Wizard : Characters, ICharacter
{
    public Wizard(string name) : base(name)
    {
    }
    public SpellsBook SpellsBook { get; set; }
    public Staff Staff { get; set; }
    
    public new int AttackValue
    {
        get { return base.AttackValue + SpellsBook.AttackValue + Staff.AttackValue; }
    }

    public new int DefenseValue
    {
        get { return base.DefenseValue + SpellsBook.DefenseValue + Staff.DefenseValue; }
    }
}