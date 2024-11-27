public class BasicSpider: Ability
{

    public BasicSpider() : base(10, AbilityType.Basic, "Sticky web") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Helen: Launching basic Attack (Sticky web)!!!! ", ConsoleColor.White);
        return Damage;
    }
}