public class UltimateSpider: Ability
{

    public UltimateSpider() : base(37, AbilityType.Ultimate, "Creeper") {}

    public override double Attack()
    {
        Dialog.WriteDialog($"Spider: Launching Ultimate Attack (Creeper)!!!! ", ConsoleColor.White);
        return Damage;
    }
}