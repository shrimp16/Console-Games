namespace Enemies;

class SavageBoar : IEnemy
{
    public int Health { get; set; } = 250;
    public int Damage { get; set; } = 20;
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Reset(){
        Health = 250;
    }

    public override string ToString()
    {
        return "Savage Boar";
    }
}