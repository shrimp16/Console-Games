using Enemies;

public interface IClass
{

    void BasicSkill(Player player, IEnemy enemy);
    void MediumSkill(Player player, IEnemy enemy);
    void UltimateSkill(Player player, IEnemy enemy);

}