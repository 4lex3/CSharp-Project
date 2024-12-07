public class Common: Enemy 
{
    public Common() : base(
        new List<Ability> { new BasicCommon() }, "Common"
    )
    {
    }
}