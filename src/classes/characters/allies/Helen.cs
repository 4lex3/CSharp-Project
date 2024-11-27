
public class Helen : CPUControlledCharacter
{
    public Helen() : base(
        new List<Ability> { new BasicHelen(), new SpecialHelen(), new UltimateHelen() },
        "Helen"

    )
    { }
}
