using Enemies;

namespace Factories;

class EnemiesFactory
{

    public IEnemy GenerateEnemy()
    {

        int randomNumber = new Random().Next(2);

        switch (randomNumber)
        {
            case 0:
                return new SavageWolf();
            case 1:
                return new SavageBoar();
            default:
                return new SavageWolf();

        }

    }
}