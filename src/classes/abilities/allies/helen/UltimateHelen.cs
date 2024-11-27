public class UltimateHelen: Ability
{

    public UltimateHelen() : base(20, AbilityType.Special, "Throwing knives") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Helen: Launching ultimate Attack (Throwing knives)!!!! ", ConsoleColor.Red);
        return Damage;
    }
}