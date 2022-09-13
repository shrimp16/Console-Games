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
        }

    }

    private CombatCommands Select()
    {
        int choice;
        string input = Console.ReadLine();
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