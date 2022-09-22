using Potions;
using Items;
namespace Shops;

public class PotionShop : INPC
{
    public void Interact(Player player)
    {
        int slot = 0;
        player.Inventory[slot] = new HealthPotion();
    }
}