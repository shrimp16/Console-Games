namespace Enemies;

public interface IEnemy
{

    int Health { get; set; }
    int Damage { get; set; }
    void TakeDamage(int damage);
}