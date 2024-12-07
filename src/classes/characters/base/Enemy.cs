public class Enemy : CPUControlledCharacter
{
    public bool hasBeenDefeated = false; 

    public Enemy(List<Ability> abilities, string name) : base(abilities, name)
    {
    }

    public void MarkAsDefeated() => hasBeenDefeated = true;
    public bool AttackOnSean() => new Random().Next(1, 3) == 1;
}