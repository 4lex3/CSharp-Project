public class BasicShadowHunter: Ability
{

    public BasicShadowHunter() : base(7, AbilityType.Basic, "Deadly fist") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Shadow Hunter: Launching basic attack (Deadly fist)!!!! ", ConsoleColor.Gray);
        return Damage;
    }
}