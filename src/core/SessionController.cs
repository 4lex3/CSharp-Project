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

    public void SaveGame(Player player)
    {

        List<Player> sessions = GetGameSessions();

        try
        {

            Player session = FindSession(sessions, player.SessionId);
            ModifySession(player.SessionId, PlayerToString(player));
            Dialog.WriteDialog("Save game!", ConsoleColor.Green);
            Console.ReadKey();

        }
        catch (DllNotFoundException e)
        {
            Dialog.WriteDialog(e.Message, ConsoleColor.Red);
        }

    }

    public void SetEnemyStates(Player player, List<Enemy> enemies){

        for (int i = 0; i < player.CurrentLevel; i++)
        {
            enemies[i].MarkAsDefeated();
        }

    }

    public Player CreateGameSession(string playerName)
    {
        if (playerName == "") throw new NullReferenceException("Error! Name is not empty");

        int sessionsQuantity = File.ReadAllLines(sessionFile).Count();

        Player newGameSession = new Player(sessionsQuantity++, playerName, 0, 0, 0, DateTime.Now, true);

        string[] gameSession = [$"{newGameSession.SessionId},{newGameSession.Name},{newGameSession.CurrentLevel},{newGameSession.Attempts},{newGameSession.TimePlayed},{newGameSession.InitialDate},{newGameSession.InProgress}"];

        File.AppendAllLines(sessionFile, gameSession);
        Dialog.WriteDialog("Saved Successfully! ");
        Console.ReadLine();

        return newGameSession;
    }

    private Player ParsePlayer(string session)
    {

        string[] row = session.Split(",");

        Player parsedPlayer = new Player(
            int.Parse(row[0]), row[1], int.Parse(row[2]), int.Parse(row[3]), int.Parse(row[4]), DateTime.Parse(row[5]), bool.Parse(row[6])
        );


        return parsedPlayer;
    }


    private Player FindSession(List<Player> sessions, int sesionId)
    {

        foreach (Player sesion in sessions)
        {
            if (sesion.SessionId == sesionId) return sesion;
        }

        throw new DllNotFoundException("Player session not found");
    }

    private void ModifySession(int sessionId, string content)
    {
        string[] sessions = File.ReadAllLines(sessionFile);
        sessions[sessionId] = content;
        File.WriteAllLines(sessionFile, sessions);
    }

    private string PlayerToString(Player player)
    {
        return $"{player.SessionId},{player.Name},{player.CurrentLevel},{player.Attempts},{player.getTimePlayed()},{player.InitialDate},{player.InProgress}";
    }

}