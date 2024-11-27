public class SpecialHelen: Ability
{

    public SpecialHelen() : base(16, AbilityType.Special, "Shadow Assault") {}

    public override double Attack()
    {

        Dialog.WriteDialog($"Helen: Launching Special Attack (Shadow Assault)!!!! ", ConsoleColor.Red);
        return Damage;
    }
}