using Items;
using Enemies;

namespace Potions;

class ManaPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Mana += 50;
    }

}