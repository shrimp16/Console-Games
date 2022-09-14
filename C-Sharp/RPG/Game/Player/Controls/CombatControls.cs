using Enemies;

namespace Controls;

public class CombatControls
{

    //needs changes like the combat class
    public void GetPlayerAttack(IEnemy enemy, Player player)
    {
        switch (Select())
        {
            case CombatCommands.BasicAttack:
                enemy.TakeDamage(player.AttackDamage);
                break;
            case CombatCommands.BasicSkill:
                player.PlayerClass.BasicSkill(player, enemy);
                break;
            case CombatCommands.MediumSkill:
                player.PlayerClass.MediumSkill(player, enemy);
                break;
            case CombatCommands.UltimateSkill:
                player.PlayerClass.UltimateSkill(player, enemy);
                break;
        }

    }

    private CombatCommands Select()
    {
        int choice;
        Console.WriteLine("1 - Basic Attack");
        Console.WriteLine("2 - Fire Ball");
        Console.WriteLine("3 - Dragon Breath");
        Console.WriteLine("4 - Lightnening Bolt");
        string input = Console.ReadKey(true).KeyChar.ToString();
        Int32.TryParse(input, out choice);
        return (CombatCommands)choice;
    }
}

enum CombatCommands
{
    BasicAttack = 1,
    BasicSkill = 2,
    MediumSkill = 3,
    UltimateSkill = 4,
}