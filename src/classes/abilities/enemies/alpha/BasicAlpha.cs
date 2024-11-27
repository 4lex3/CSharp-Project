public class BasicAlpha : Ability
{

    public BasicAlpha() : base(10, AbilityType.Basic, "Brutal Strike") {}
    public override double Attack()
    {
        Dialog.WriteDialog($"Alpha: Launching basic Attack (Precise Strike)!!!! ", ConsoleColor.Magenta);
        return Damage;
    }
}