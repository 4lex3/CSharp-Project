public class BasicSean : Ability
{

    public BasicSean() : base(3, AbilityType.Basic, "Knife Attack") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Sean: Launching basic Attack (Knife Attack)!!!! ", ConsoleColor.Cyan);
        return Damage;
    }
}