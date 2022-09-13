using Items;
using Pets;
using Classes;
public class Player
{

    public IClass PlayerClass { get; set; } = null!;
    public int Health { get; set; }
    public int Resistance { get; set; }
    public int Mana { get; set; }
    public int AttackDamage { get; set; }
    public int MagicDamage { get; set; }
    public IItems[]? Inventory { get; set; }
    public IPets[]? Pets { get; set; }

    public Player(int health)
    {
        this.Health = health;
        AttackDamage = 50;
        MagicDamage = 100;
        Mana = 500;
        PlayerClass = new Mage();
    }

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
    }

}