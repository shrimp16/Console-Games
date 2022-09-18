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
    public List<IItems> Inventory { get; set; }
    public List<IPets> Pets { get; set; }

    public Player()
    {
        Health = 1000;
        Resistance = 0;
        Mana = 500;
        AttackDamage = 50;
        MagicDamage = 0;
        Inventory = new List<IItems>();
        Pets = new List<IPets>();
    }

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
    }

}