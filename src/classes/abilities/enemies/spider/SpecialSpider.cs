public class SpecialSpider: Ability
{

    public SpecialSpider() : base(36, AbilityType.Special, "Poison") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Spider : Launching Special Attack (Poison)!!!! ", ConsoleColor.White);
        return Damage;
    }
}