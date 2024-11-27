public class BasicHelen : Ability
{

    public BasicHelen() : base(4, AbilityType.Basic, "Precise Strike") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Helen: Launching basic Attack (Precise Strike)!!!! ", ConsoleColor.Red);
        return Damage;
    }
}