using Potions;
using Items;
namespace Shops;

public class PotionShop : INPC
{
    public IItems[] stock = new IItems[]{
            new SmallHealthPotion(),
            new HealthPotion(),
            new BigHealthPotion(),
            new SmallManaPotion(),
            new ManaPotion(),
            new BigManaPotion()
        };

    public string[] stock_list = new string[]{
        "╔═════════════════════════╗\n" +
        "║   Small Health Potion   ║\n" +
        "╚═════════════════════════╝",
        "╔═════════════════════════╗\n" +
        "║      Health Potion      ║\n" +
        "╚═════════════════════════╝",
        "╔═════════════════════════╗\n" +
        "║    Big Health Potion    ║\n" +
        "╚═════════════════════════╝",
        "╔═════════════════════════╗\n" +
        "║    Small Mana Potion    ║\n" +
        "╚═════════════════════════╝",
        "╔═════════════════════════╗\n" +
        "║       Mana Potion       ║\n" +
        "╚═════════════════════════╝",
        "╔═════════════════════════╗\n" +
        "║      Big Mana Potion    ║\n" +
        "╚═════════════════════════╝",
    };

    public string[] simple_stock = new string[]{
        "Small Health Potion",
        "Heal Potion",
        "Big Health Potion",
        "Small Mana Potion",
        "Mana Potion",
        "Big Mana Potion"
    };
    public int[] prices = new int[]{
        50, 100, 150, 65, 130, 195
    };

    public void Interact(Player player)
    {
        Menu menu = new Menu(stock_list);
        menu.Show();
        int opt = menu.GetOption();
        Console.Clear();
        Console.WriteLine("Want to buy {0} for {1}$?", simple_stock[opt], prices[opt]);
        Console.WriteLine("Y - Yes");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            for (int i = 0; i < player.Inventory.Length; i++)
            {
                if (player.Inventory[i] == null)
                {
                    player.Inventory[i] = stock[opt];
                    return;
                }
            }
        }
        else
        {
            Interact(player);
        }
    }
}