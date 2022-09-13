using Enemies;
using Controls;
public class Combat
{
    public IEnemy Enemy { get; private set; }
    public Player Player { get; private set; }
    public CombatControls combatControls { get; set; }
    public bool inCombat = false;
    public Combat(IEnemy Enemy, Player Player)
    {
        this.Enemy = Enemy;
        this.Player = Player;
        this.combatControls = new CombatControls();
    }

    public void StartCombat()
    {
        inCombat = true;
        while (inCombat)
        {
            // This needs changes, the attack is the one that should do this.
            //Enemy.TakeDamage(combatControls.GetPlayerAttack(Player));
            combatControls.GetPlayerAttack(Enemy, Player);
            if (Enemy.Health <= 0)
            {
                Console.WriteLine("The player won!");
                inCombat = false;
                ShowHealth();
                return;
            }
            Player.TakeDamage(Enemy.Damage);
            if (Player.Health <= 0)
            {
                Console.WriteLine("The enemy won!");
                inCombat = false;
            }
            ShowHealth();
        }
    }

    public void ShowHealth()
    {
        Console.WriteLine("Player HP: {0}", Player.Health);
        Console.WriteLine("Enemy HP: {0}", Enemy.Health);
    }
}