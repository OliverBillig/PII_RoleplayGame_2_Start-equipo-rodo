namespace Ucu.Poo.RoleplayGame;

public class Items : IItems
{
    public int AttackValue { get; protected set; }
    public int DefenseValue { get; protected set; }

    public Items(int attackValue, int defenseValue)
    {
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}