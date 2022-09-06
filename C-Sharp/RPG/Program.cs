using Enemies;
using Factories;
class Program
{
    static void Main(string[] args)
    {
        EnemiesFactory factory = new EnemiesFactory();
        IEnemy enemy = factory.GenerateEnemy();
        Player player = new Player(1000);
        Console.WriteLine(enemy.ToString());
        while (player.Health > 0 && enemy.Health > 0)
        {
            enemy.TakeDamage(player.AttackDamage);
            player.TakeDamage(enemy.Damage);
            Console.WriteLine("Player HP: {0}", player.Health);
            Console.WriteLine("Enemy HP: {0}", enemy.Health);
        }
    }
}