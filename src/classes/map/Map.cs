public class Map
{
    public List<Enemy> enemies { get; }

    public Map(List<Enemy> enemies)
    {

        this.enemies =  enemies;
        
    }

    public void ShowMap()
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine($"======================================================================    Map   ========================================================================= \n\n\n\n\n");


        foreach (Enemy enemy in enemies)
        {
            if (enemy.hasBeenDefeated)
            {
                Console.Write($"\t {enemy.CharacterName} 🟢       ");
            }
            else
            {
                Console.Write($"\t {enemy.CharacterName} 🔴       ");
            }

        }

        Console.WriteLine($"\n\n\n\n\n======================================================================    Map   ========================================================================= ");
        Console.WriteLine("\n\n\n\n\n");
        Console.ResetColor();

    }


    public Enemy GetEnemy(Player player) => enemies[player.CurrentLevel];
}