using Enemies;
using Factories;
class Program
{
    static void Main(string[] args)
    {
        EnemiesFactory factory = new EnemiesFactory();
        IEnemy enemy = factory.GenerateEnemy();
        Player player = new Player(1000);
        Combat combat = new Combat(enemy, player);
        combat.StartCombat();
    }
}