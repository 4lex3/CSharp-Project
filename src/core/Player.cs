public class Player {
    public int SessionId { get; }
    public string Name { get; }
    public int CurrentLevel { get; private set;} 
    public int Attempts { get; set; }
    public double TimePlayed { get; }
    public DateTime InitialDate { get;  }
    public bool InProgress { get; set; }


    public Player(
        int sessionId, string name, int currentLevel, int attempts, int timePlayed, DateTime initialDate, bool inProgress
    )
    {
        SessionId = sessionId;
        Name = name;
        CurrentLevel = currentLevel;
        Attempts = attempts;
        TimePlayed = timePlayed;
        InitialDate = initialDate;
        InProgress = inProgress;
    }
    public void FinishGame()
    {
        InProgress = false;
    }
    public double getTimePlayed() => (InitialDate - DateTime.Now).Hours;
    public void UpLevel () => CurrentLevel++;
    public void AddNewAttempt() => Attempts++;
}