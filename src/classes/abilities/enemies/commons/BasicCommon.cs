public class Common : Ability
{

    public Common() : base(3, AbilityType.Basic, "Scratch") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Common: Launching basic Attack (Scratch)!!!! ", ConsoleColor.Red);
        return Damage;
    }
}