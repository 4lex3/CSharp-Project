public class Sean : BaseCharacter
{
    private EnergyController energyController;
    private List<AbilityWithCost> abilities;

    public Sean(List<AbilityWithCost> abilities, string name, EnergyController energyController) : base(name)
    {
        this.energyController = energyController;
        this.abilities = abilities;
    }


    public override AttackInfo Attack(BaseCharacter target)
    {

        do
        {

            try
            {

                int abilityNumber = Input.SelectInput("Select your ability", GetAbilityOptions(), ConsoleColor.Yellow);


                if (abilityNumber == 4) return HandleLuckyShot();


                if (!(energyController.GetEnergyPoints() >= abilities[abilityNumber - 1].Cost)) throw new InvalidOperationException("\nNot enough energy points to use this ability.");


                energyController.UseEnergyPoints(abilities[abilityNumber - 1]);


                AttackInfo attackSelected;

                attackSelected.damage = abilities[abilityNumber - 1].Damage;
                attackSelected.attackLog = $"{CharacterName}:   \t\t-\tLaunching attack ({abilities[abilityNumber - 1].AbilityName}) to {target.CharacterName}  (-{abilities[abilityNumber - 1].Damage})";

                target.Health -= attackSelected.damage;
                energyController.AddEnergyPointsByDamage(attackSelected.damage);


                return attackSelected;

            }
            catch (IndexOutOfRangeException e)
            {
                Dialog.WriteDialog(e.Message, ConsoleColor.Red);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Dialog.WriteDialog($"Option is a number! ", ConsoleColor.Red);
                Console.ReadKey();
            }
            catch (InvalidOperationException e)
            {
                Dialog.WriteDialog($"{e.Message}");
                Console.ReadKey();
            }


        } while (true);

    }

    public bool LuckyShotSpawnByGame() => energyController.LuckyShotSpawn();
    public void RestartEnergyPointsByGame() => energyController.RestartEnergyPoints();
    public int GetCurrentEnergyPoints() => energyController.GetEnergyPoints();



    private AttackInfo HandleLuckyShot()
    {
        energyController.LuckyShot = false;

        if (!energyController.ExecuteLuckyShot())
        {
            AttackInfo falseLuckyShot;

            falseLuckyShot.attackLog = "Sean:   \t\t\t\tLucky Shot => -25 HP";
            falseLuckyShot.damage = 25;

            energyController.TakeLifeByLuckyShot(this);

            return falseLuckyShot;

        }

        AttackInfo luckyShot;

        luckyShot.attackLog = "Sean:  \t\t\t\tLucky Shot =>   +25 Energy Points";
        luckyShot.damage = 0;

        energyController.AddPointsByLuckyShow();

        return luckyShot;

    }


    private List<string> GetAbilityOptions()
    {
        List<string> abilitiesOptions = new List<string>();

        foreach (AbilityWithCost ability in abilities)
        {
            abilitiesOptions.Add($"Name: {ability.AbilityName} - {ability.Type} : Damage {ability.Damage}  => ${ability.Cost}");
        }

        if (energyController.LuckyShot)
        {
            abilitiesOptions.Add("Lucky Shot!!!");
        }

        return abilitiesOptions;
    }

}