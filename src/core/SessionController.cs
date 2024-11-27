public class SessionController
{
    private const string sessionFile = "src/progress/gameSessions.csv";

    public List<Player> GetGameSessions()
    {
        if (!File.Exists(sessionFile)) throw new FileNotFoundException("Session File not exists!");

        string[] sessions = File.ReadAllLines(sessionFile);
        List<Player> parsedSessions = new List<Player>();

        foreach (string session in sessions)
        {
            parsedSessions.Add(ParsePlayer(session));
        }

        return parsedSessions;
    }

    public Player LoadGame(int sessionId)
    {
        string[] sessions = File.ReadAllLines(sessionFile);

        foreach (string session in sessions)
        {
            string[] row = session.Split(",");

            if (int.Parse(row[0]) == sessionId) return ParsePlayer(session);
        }

        throw new Exception("Session not found!");
    }

    public Player CreateGameSession(string playerName)
    {
        if(playerName == "") throw new NullReferenceException("Error! Name is not empty");

        int sessionsQuantity = File.ReadAllLines(sessionFile).Count();

        Player newGameSession = new Player(sessionsQuantity++, playerName, 0, 0, 0, 0, DateTime.Now, true);

        string[] gameSession = [$"{newGameSession.SessionId},{newGameSession.Name},{newGameSession.CurrentLevel},{newGameSession.Points},{newGameSession.Attempts},{newGameSession.TimePlayed},{newGameSession.InitialDate},{newGameSession.InProgress}"];

        File.AppendAllLines(sessionFile, gameSession);
        Dialog.WriteDialog("Saved Successfully! ");
        Console.ReadLine();

        return newGameSession;
    }

    private Player ParsePlayer(string session)
    {

        string[] row = session.Split(",");

        Player parsedPlayer = new Player(
            int.Parse(row[0]), row[1], int.Parse(row[2]), int.Parse(row[3]), int.Parse(row[4]), int.Parse(row[5]), DateTime.Parse(row[6]), bool.Parse(row[7])
        );

        return parsedPlayer;
    }

}