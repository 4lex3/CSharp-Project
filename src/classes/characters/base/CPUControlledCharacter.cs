public class CPUControlledCharacter : BaseCharacter
{
    public CPUControlledCharacter (List<Ability> abilities, string name): base(abilities, name) {}

    public double AutoAttack(){
        int randomAttack = new Random().Next(1, abilities.Count); 
        return abilities[randomAttack].Attack();
    }
}