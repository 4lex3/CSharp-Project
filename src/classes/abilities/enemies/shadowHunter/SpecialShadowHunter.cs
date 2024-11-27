public class SpecialShadowHunter: Ability
{

    public SpecialShadowHunter() : base(22, AbilityType.Special, "Deadly scratches") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Shadow Hunter: Launching Special Attack (Deadly scratches)!!!! ", ConsoleColor.Gray);
        return Damage;
    }
}