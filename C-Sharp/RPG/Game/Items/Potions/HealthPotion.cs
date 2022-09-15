using Items;
using Enemies;

namespace Potions;

class HealthPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Health += 50;
    }

}