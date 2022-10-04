using Enemies;

namespace Factories;

class EnemiesFactory
{

    //NEED TO WORK ON THIS PROBABILITIES

    public IEnemy[] enemies = new IEnemy[]{
        new SavageWolf(),
        new SavageBoar()
    };

    public IEnemy GenerateEnemy()
    {

        int randomNumber = new Random().Next(2);
        enemies[randomNumber].Reset();
        return enemies[randomNumber];

    }
}