public class Ability
{

    public double Damage { get; set; }
    public string AbilityName { get; set; }
    public AbilityType Type { get; set; }
    public double AttackLog {get; set;}
    


    public Ability(double damage, AbilityType type, string abilityName)
    {
        Damage = damage;
        Type = type;
        AbilityName = abilityName;
    }

}