public class Colin: Enemy 
{
    public Colin() : base(
        new List<Ability> { new BasicColin() }, "Colin"
    )
    {
    }
}