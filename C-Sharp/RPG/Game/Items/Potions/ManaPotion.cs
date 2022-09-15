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

    public void GetDescription(){
        Console.WriteLine("A Small Mana Potion that will give you 50 mana power!");
    }

}

class ManaPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Mana += 250;
    }

    public void GetDescription(){
        Console.WriteLine("A Mana Potion that will give you 250 mana power!");
    }

}

class BigManaPotion : IItems {

    public void Use(IEnemy enemy){
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player){
        player.Mana += 500;
    }

    public void GetDescription(){
        Console.WriteLine("A Big Mana Potion that will give you 500 mana power!");
    }

}