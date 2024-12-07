public class Alpha :  Enemy
{
    
    public Alpha() : base(
        new List<Ability> { new BasicAlpha(), new SpecialAlpha(), new UltimateAlpha() }, "Alpha"
    )
    {
    }

}

