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
        "Small Health Potion",
        "Health Potion",
        "Big Health Potion",
        "Small Mana Potion",
        "Mana Potion",
        "Big Mana Potion"
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