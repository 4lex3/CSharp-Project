public class SpecialAlpha: Ability
{

    public SpecialAlpha() : base(20, AbilityType.Special, "Roar") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Alpha: Launching Special Attack (Roar)!!!! ", ConsoleColor.Red);
        return Damage;
    }
}