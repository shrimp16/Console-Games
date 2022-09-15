using Items;
using Enemies;

namespace Potions;

class SmallManaPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Mana += 50;
    }

}

class ManaPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Mana += 250;
    }

}

class BigManaPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Mana += 500;
    }

}