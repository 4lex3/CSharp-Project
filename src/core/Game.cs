class Game
{
    private Player player;
    private SessionController sessionController;
    private Map map;
    private Helen helen;
    private Sean sean;
    private BattleController battleController;


    public Game(Player player, SessionController sessionController, Map map, Helen helen, Sean sean, BattleController battleController)
    {
        this.sessionController = sessionController;
        this.map = map;
        this.helen = helen;
        this.sean = sean;
        this.battleController = battleController;
        this.player = player;
    }

    public void Start()
    {
        Console.Clear();
        int option = UiGame.Menu();

        if (option == 1)
        {

            string name;

            name = Input.TextInput("\nEnter your name: ");
            player = sessionController.CreateGameSession(name);
            HistoryUI.StartStory();
            BattleSelectorLoop();

        }
        if (option == 2)
        {
            List<Player> sessions = sessionController.GetGameSessions();
            player = UiGame.SessionSelector(sessions);
            sessionController.SetEnemyStates(player, map.enemies);
            BattleSelectorLoop();
        }

        if (option == 3)
        { 
            UiGame.Exit();
        }
    }


    private void BattleSelectorLoop()
    {
        battleController = new BattleController(player, helen, sean);
        Enemy currentEnemy;

        do
        {

            int submenuOption = UiGame.SubMenu(map.ShowMap);
            currentEnemy = map.GetEnemy(player);

            switch (submenuOption)
            {
                case 1:
                    HistoryUI.ShowHistoryByEnemy(currentEnemy);
                    sean.LuckyShotSpawnByGame();
                    sean.RestartEnergyPointsByGame();
                    battleController.StartBattle(currentEnemy);
                    break;

                case 2:
                    sessionController.SaveGame(player);
                    break;
            }

        } while (currentEnemy.CharacterName != "Colin");
    }

}