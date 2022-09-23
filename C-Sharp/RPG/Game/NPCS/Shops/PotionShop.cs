using Potions;
using Items;
namespace Shops;

public class PotionShop : INPC
{
    public void Interact(Player player)
    {
        for(int i = 0; i < player.Inventory.Length; i++){
            if(player.Inventory[i] == null){
                player.Inventory[i] = new HealthPotion();
                return;
            }
        }
    }
}