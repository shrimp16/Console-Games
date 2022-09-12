namespace Controls;

public class CombatControls
{

    //needs changes like the combat class
    public int GetPlayerAttack(Player player)
    {
        switch (Select())
        {
            case CombatCommands.BasicAttack:
                return player.AttackDamage;
            default:
                return player.AttackDamage;
        }

    }

    private CombatCommands Select()
    {
        return CombatCommands.BasicAttack;
    }
}

enum CombatCommands
{
    BasicAttack,
    BasicSkill,
    MediumSkill,
    UltimateSkill,
}