namespace Enemies;

class SavageWolf : IEnemy
{

    public int Health { get; set; } = 100;
    public int Damage { get; set; } = 15;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Reset(){
        Health = 100;
    }

    public override string ToString()
    {
        return "Savage Wolf";
    }
}