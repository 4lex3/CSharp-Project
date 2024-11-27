public class UltimateAlpha: Ability
{

    public UltimateAlpha() : base(40, AbilityType.Ultimate, "Final blow") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Alpha: Launching Ultimate Attack (Precise )!!!! ", ConsoleColor.Red);
        return Damage;
    }
}