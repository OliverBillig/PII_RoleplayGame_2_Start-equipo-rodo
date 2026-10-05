using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame;

public class SpellsBook : IItems
{
    public List<Spell> Spells { get; private set; } = new List<Spell>();

    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }

    public void AddSpell(Spell spell)
    {
        if (spell != null)
        {
            this.Spells.Add(spell);
        }
    }
}