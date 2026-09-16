namespace Ucu.Poo.RoleplayGame;

public class Dwarf
{
    private int health = 100;
    public Dwarf(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    public Axe Axe { get; set; }
    public Shield Shield { get; set; }
    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Axe.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Shield.DefenseValue + Helmet.DefenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            if (value < 0)
            {
                this.health = 0;
            }
            else
            {
                this.health = value;
            }
        }
    }

    public void ReceiveAttack(int damage)
    {
        if (this.DefenseValue < damage)
        {
            this.Health -= damage - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
}