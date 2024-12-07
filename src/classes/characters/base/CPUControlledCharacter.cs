public class CPUControlledCharacter : BaseCharacter
{

    protected List<Ability> abilities; 
    public CPUControlledCharacter (List<Ability> abilities, string name): base(name) {
        this.abilities = abilities;
    }

    public override AttackInfo Attack(BaseCharacter target){

        AttackInfo attack;
        Ability selectedAbility = abilities[new Random().Next(0, abilities.Count)];

        attack.attackLog = $"{CharacterName}:   \t\t\tLaunching attack ({selectedAbility.AbilityName}) to {target.CharacterName} (-{selectedAbility.Damage})";
        
        attack.damage = selectedAbility.Damage;
        target.Health -= selectedAbility.Damage;

        return attack;
    }

}