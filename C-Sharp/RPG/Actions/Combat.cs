using Enemies;

namespace Combat;

public class Combat
{
    public IEnemy Enemy { get; private set; }
    public Player Player { get; private set; }
    public Combat(IEnemy Enemy, Player Player)
    {
        this.Enemy = Enemy;
        this.Player = Player;
    }
}