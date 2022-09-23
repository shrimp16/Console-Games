using Enemies;
using Factories;
using Shops;
using Items;
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        // COMBAT
        /*EnemiesFactory factory = new EnemiesFactory();
        IEnemy enemy = factory.GenerateEnemy();
        Combat combat = new Combat(enemy, player);
        combat.StartCombat();*/

        // BUY
        INPC PotionShop = new PotionShop();
        PotionShop.Interact(player);
        PotionShop.Interact(player);
        PotionShop.Interact(player);
        PotionShop.Interact(player);
        foreach (IItems item in player.Inventory)
        {
            if (item != null)
            {
                item.GetDescription();
            }
        }
    }
}