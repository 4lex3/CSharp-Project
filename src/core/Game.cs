class Game
{
    private Player currentPlayer;
    private SessionController sessionController;


    public Game()
    {
        sessionController= new SessionController();
    }


    public void Start()
    {
        Console.Clear();
        int option = UiGame.Menu();

        if (option == 1)
        {

            string name;


            while (true)
            {
                try
                {
                    Dialog.WriteDialog("\nEnter your name: ", ConsoleColor.Blue); name = Console.ReadLine();
                    currentPlayer = sessionController.CreateGameSession(name);
                    break;

                }
                catch (NullReferenceException e)
                {
                    Dialog.WriteDialog($"{e.Message}", ConsoleColor.Red);
                    Console.ReadKey();
                }
            }


            Console.Clear();
            UiGame.StartStory();
            Dialog.WriteDialog("\n\n\n\n\nPress any key to continue .... ", ConsoleColor.Yellow);
            Console.ReadKey();
            Console.Clear();





        }

        if (option == 2)
        {
            List<Player> sessions = sessionController.GetGameSessions();
            currentPlayer = UiGame.SessionSelector(sessions); 



        }

        if (option == 3){ //Dialog.WriteDialog("See your later....", ConsoleColor.Yellow);
            Helen helen = new Helen();
            helen.AutoAttack();
        } 
    }

}