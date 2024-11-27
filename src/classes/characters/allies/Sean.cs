public class Sean : BaseCharacter
{
    public Sean() : base(
        new List<Ability> { new BasicSean(), new SpecialSean(), new UltimateSean() },
        "Sean"
    )
    { }
}