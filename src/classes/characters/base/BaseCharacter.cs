public abstract class BaseCharacter
{
    public double Health { get; set; }
    public string CharacterName { get; set; }

    public BaseCharacter( string name){
        Health = 100;
        CharacterName = name;
    }

    public abstract AttackInfo Attack(BaseCharacter target);

}