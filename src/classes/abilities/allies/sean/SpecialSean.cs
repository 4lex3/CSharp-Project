public class SpecialSean: Ability
{

    public SpecialSean() : base(7, AbilityType.Special, "Burst of Gunfire") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Sean: Launching Special Attack (Burst of gunfire)!!!! ", ConsoleColor.Cyan);
        return Damage;
    }
}