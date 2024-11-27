public abstract class Ability
{

    public double Damage { get; set; }
    public string AbilityName { get; set; }
    public AbilityType Type { get; set; }

    private int level = 0;


    public Ability(double damage, AbilityType type, string abilityName)
    {
        Damage = damage;
        Type = type;
        AbilityName = abilityName;
    }

    public abstract double Attack();

    public int UpLevel()
    {
        if (level > 3) return level;

        level++;
        Damage = Damage * 2;
        return level;
    }
}
