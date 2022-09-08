namespace Controls;

class CombatControls
{

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

    public CombatCommands Select()
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