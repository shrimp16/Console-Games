using Enemies;

namespace Items;

public interface IItems {

    void Use(Player player);
    void Use(IEnemy enemy);
    void GetDescription();
}