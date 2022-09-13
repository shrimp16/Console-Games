using Enemies;

namespace Classes;

class Mage : IClass
{
    public void BasicSkill(Player player, IEnemy enemy)
    {
        if(player.Mana < 50){
            Console.WriteLine("Not enough mana!");
            return;
        }
        player.Mana -= 50;
        Console.WriteLine("Fire ball!");
        enemy.TakeDamage(player.MagicDamage / 2);
    }

    public void MediumSkill(Player player, IEnemy enemy)
    {
        if(player.Mana < 100){
            Console.WriteLine("Not enough mana!");
            return;
        }
        player.Mana -= 100;
        Console.WriteLine("Dragon breath!");
        enemy.TakeDamage(player.MagicDamage);
    }

    public void UltimateSkill(Player player, IEnemy enemy)
    {
        if(player.Mana < 500){
            Console.WriteLine("Not enough mana!");
            return;
        }
        player.Mana -= 500;
        Console.WriteLine("Lightening bolt!");
        enemy.TakeDamage(player.MagicDamage * 2);
    }
}