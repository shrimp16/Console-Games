using Potions;
using Items;
namespace Shops;

public class PotionShop : INPC
{
    public void Interact(Player player)
    {
        Menu menu = new Menu(new string[]{"lmao", "xd", "lol", "bruh"});
        menu.Show();
        /*for(int i = 0; i < player.Inventory.Length; i++){
            if(player.Inventory[i] == null){
                player.Inventory[i] = new HealthPotion();
                return;
            }
        }*/
    }
}