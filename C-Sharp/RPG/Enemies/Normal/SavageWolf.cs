namespace Enemies;

class SavageWolf : IEnemy
{

    int Health = 100;
    int Damage = 15;
    
    public void TakeDamage(int damage){
        Health -= damage;
    }
}