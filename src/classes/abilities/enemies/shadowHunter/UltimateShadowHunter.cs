public class UltimateShadowHunter: Ability
{

    public UltimateShadowHunter() : base(30, AbilityType.Ultimate, "Fire") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Shadow Hunter: Launching Ultimate Attack (Fire)!!!! ", ConsoleColor.Gray);
        return Damage;
    }
}