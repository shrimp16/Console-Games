using Potions;
using Items;
namespace Shops;

public class PotionShop : IShop
{
    public IItems[] Interact(IItems[] inventory)
    {
        int slot = 0;
        inventory[slot] = new HealthPotion();
        return inventory;
    }
}