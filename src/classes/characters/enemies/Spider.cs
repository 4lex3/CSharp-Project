public class Spider : Enemy 
{
    public Spider() : base(
        new List<Ability> { new BasicSpider(), new SpecialSpider(), new UltimateSpider() }, "Spider"
    )
    {
    }
}