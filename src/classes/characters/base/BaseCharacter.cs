public class BaseCharacter
{
    public int Health { get; set; }
    public string CharacterName { get; set; }
    protected List<Ability> abilities; 

    public BaseCharacter(List<Ability> abilities, string name){
        this.abilities = abilities;
        Health = 100;
        CharacterName = name;
    }

}