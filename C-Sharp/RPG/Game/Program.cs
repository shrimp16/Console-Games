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
        IShop PotionShop = new PotionShop();
        player.Inventory = PotionShop.Interact(player.Inventory);
        foreach (IItems item in player.Inventory)
        {
            if (item != null)
            {

                item.GetDescription();
            }
        }
    }
}