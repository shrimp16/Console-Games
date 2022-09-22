using Items;

namespace Shops;

public interface IShop {
    IItems[] Interact(IItems[] inventory);
}