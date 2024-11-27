
public class Player
{
    public int SessionId { get; set; }
    public string Name { get; set; }
    public int CurrentLevel { get; set; }
    public int Points { get; set; }
    public int Attempts { get; set; }
    public double TimePlayed { get; set; }
    public DateTime InitialDate { get; set; }
    public bool InProgress { get; set; }


    public Player(
        int sessionId, string name, int currentLevel, int points, int attempts, int timePlayed, DateTime initialDate, bool inProgress
    )
    {
        SessionId = sessionId;
        Name = name;
        CurrentLevel = currentLevel;
        Points = points;
        Attempts = attempts;
        TimePlayed = timePlayed;
        InitialDate = initialDate;
        InProgress = inProgress;
    }

    public void AddPointsByNormalEnemy() => Points += 4;
    public void AddPointsByBoss() => Points += 7;
    public void AddPointsByInsaneBoss() => Points += 10;

    public void FinishGame()
    {
        InProgress = false;
    }

    public void ShowPlayerStats()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine($"Name:               {Name}");
        Console.WriteLine($"CurrentLevel:       {CurrentLevel}");
        Console.WriteLine($"Points:             {Points}");
        Console.WriteLine($"Attempts:           {Attempts}");
        Console.WriteLine($"Time Played:        {TimePlayed}");
        Console.WriteLine($"Initial Date:       {InitialDate}");
        Console.WriteLine($"In Progress:        {InProgress}");


        Console.ReadKey();
        Console.ResetColor();
    }

    public double getTimePlayed() => (InitialDate - DateTime.Now).Hours;
}