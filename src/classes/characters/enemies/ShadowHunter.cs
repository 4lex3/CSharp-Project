public class ShadowHunter: Enemy 
{
    public ShadowHunter() : base(
        new List<Ability> { new BasicShadowHunter(), new SpecialShadowHunter(), new UltimateShadowHunter() }, "Shadow Hunter"
    )
    {
    }
}