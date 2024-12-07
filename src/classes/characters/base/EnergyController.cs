public class EnergyController
{
    private int energyPoints;
    public bool LuckyShot { get; set; } = false;


    public EnergyController(int initialPoints = 0)
    {
        energyPoints = initialPoints;
    }


    public void AddEnergyPointsByDamage(double damage)
    {
        double damageToPointsRatio = 1.0;
        energyPoints += (int)Math.Ceiling(damage / damageToPointsRatio);
    }


    public void RestartEnergyPoints() => energyPoints = 5;
    public int GetEnergyPoints() => energyPoints;
    public int UseEnergyPoints(AbilityWithCost ability) => energyPoints -= ability.Cost;
    public bool LuckyShotSpawn() => LuckyShot = new Random().Next(1, 7) <= 2;
    public bool ExecuteLuckyShot() => new Random().Next(0, 13) >= 7;
    public void AddPointsByLuckyShow() => energyPoints += 25;
    public void TakeLifeByLuckyShot(Sean sean) => sean.Health -= 25;
}