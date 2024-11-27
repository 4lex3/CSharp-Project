public class UltimateSean: Ability
{

    public UltimateSean() : base(18, AbilityType.Ultimate, "Explosion trap") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Sean: Launching ultimate (Explosion trap)!!!! ", ConsoleColor.Cyan);
        return Damage;
    }
}