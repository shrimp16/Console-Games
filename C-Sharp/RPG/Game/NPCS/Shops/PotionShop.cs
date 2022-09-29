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

    public void Interact(Player player)
    {
        Menu menu = new Menu(stock_list);
        menu.Show();
        /*for(int i = 0; i < player.Inventory.Length; i++){
            if(player.Inventory[i] == null){
                player.Inventory[i] = new HealthPotion();
                return;
            }
        }*/
    }
}