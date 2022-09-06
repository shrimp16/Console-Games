using Items;
using Pets;

class Player
{

    public IClass PlayerClass { get; set; } = null!;
    public int Health { get; set; }
    public int Resistance { get; set; }
    public int AttackDamage { get; set; }
    public int MagicDamage { get; set; }
    public IItems[]? Inventory { get; set; }
    public IPets[]? Pets { get; set; }

    public Player(int health){
        this.Health = health;
        AttackDamage = 20;
    }

    public void TakeDamage(int damage){
        Health = Health - damage;
    }

}