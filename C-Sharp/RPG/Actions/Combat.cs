using Enemies;

public class Combat
{
    public IEnemy Enemy { get; private set; }
    public Player Player { get; private set; }
    public bool inCombat = false;
    public Combat(IEnemy Enemy, Player Player)
    {
        this.Enemy = Enemy;
        this.Player = Player;
    }

    public void StartCombat(){
        inCombat = true;
        while(inCombat){
            Enemy.TakeDamage(Player.AttackDamage);
            Player.TakeDamage(Enemy.Damage);
            Console.WriteLine("Player HP: {0}", Player.Health);
            Console.WriteLine("Enemy HP: {0}", Enemy.Health);

            if(Enemy.Health <= 0 || Player.Health <= 0){
                inCombat = false;
            }
        }
    }
}