using Items;
using Enemies;

namespace Potions;

class SmallHealthPotion : IItems
{
    public void Use(IEnemy enemy)
    {
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player)
    {
        player.Health += 50;
    }

    public void GetDescription(){
        Console.WriteLine("A Small Health Potion that will heal you for 50!");
    }
}
class HealthPotion : IItems
{

    public void Use(IEnemy enemy)
    {
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player)
    {
        player.Health += 250;
    }

    public void GetDescription(){
        Console.WriteLine("A Health Potion that will heal you for 250!");
    }

}

class BigHealthPotion : IItems
{
    public void Use(IEnemy enemy)
    {
        Console.WriteLine("Why are you trying to help your enemies?");
    }

    public void Use(Player player)
    {
        player.Health += 500;
    }

    public void GetDescription(){
        Console.WriteLine("A Big Health Potion that will heal you for 500!");
    }
}