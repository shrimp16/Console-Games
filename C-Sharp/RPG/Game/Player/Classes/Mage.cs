using Enemies;

namespace Classes;

class Mage
{
    public void BasicSkill(Player player, IEnemy enemy)
    {
        Console.WriteLine("Fire ball!");
        enemy.TakeDamage(player.MagicDamage / 2);
    }

    public void MediumSkill(Player player, IEnemy enemy)
    {
        Console.WriteLine("Dragon breath!");
        enemy.TakeDamage(player.MagicDamage);
    }

    public void UltimateSkill(Player player, IEnemy enemy)
    {
        Console.WriteLine("Lightening bolt!");
        enemy.TakeDamage(player.MagicDamage * 2);
    }
}