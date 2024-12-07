public class AbilityWithCost : Ability
{
    public int Cost {get; set;}
    public AbilityWithCost(double damage, AbilityType type, string abilityName, int cost) : base(damage, type, abilityName)
    {
        Cost = cost;
    }
}