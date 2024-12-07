public class UiGame
{

    public static int Menu()
    {

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine(@"


                __________                __                     ___ ___              .__                            
                \______   \_______  ____ |  | __ ____   ____    /   |   \  ___________|__|___________   ____   ______
                |    |  _/\_  __ \/  _ \|  |/ // __ \ /    \  /    ~    \/  _ \_  __ \  \___   /  _ \ /    \ /  ___/
                |    |   \ |  | \(  <_> )    <\  ___/|   |  \ \    Y    (  <_> )  | \/  |/    (  <_> )   |  \\___ \ 
                |______  / |__|   \____/|__|_ \\___  >___|  /  \___|_  / \____/|__|  |__/_____ \____/|___|  /____  >
                        \/                    \/    \/     \/         \/                       \/          \/     \/ 

        
            ");

            Console.WriteLine($"------------------------------------------                      󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼                 ----------------------------------------------------\n\n\n");


            try
            {
                return Input.SelectInput("Select Option", new List<string> { "Create Game Session and Start", "Load Game", "Exit" });
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

        } while (true);

    }

    public static Player SessionSelector(List<Player> sessions)
    {

        while (true)
        {

            try
            {
                List<string> sessionsString = new List<string>();

                foreach (Player session in sessions)
                {
                    sessionsString.Add(@$"
                Name: {session.Name}
                Level: {session.CurrentLevel}
                Attempts: {session.Attempts}
                ");
                }

                int option = Input.SelectInput("Select your session", sessionsString);

                return sessions[option - 1];

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

        }

    }





    public static int SubMenu(Action showMap)
    {

        do
        {

            Console.Clear();
            showMap();

            try
            {
                List<string> options = new List<string> { "Start at current level", "Booster Shop", "Save Game and Exit" };
                return Input.SelectInput("Select your option: ", options);
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

        } while (true);
    }

    public static void Exit(){
        Console.Clear();
        Dialog.WriteDialog(@"
        

                ██████╗  ██████╗  ██████╗ ██████╗ ██████╗ ██╗   ██╗███████╗██╗
                ██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝██╔════╝██║
                ██║  ███╗██║   ██║██║   ██║██║  ██║██████╔╝ ╚████╔╝ █████╗  ██║
                ██║   ██║██║   ██║██║   ██║██║  ██║██╔══██╗  ╚██╔╝  ██╔══╝  ╚═╝
                ╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝██████╔╝   ██║   ███████╗██╗
                ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝ ╚═════╝    ╚═╝   ╚══════╝╚═╝
                                                               

        
        ", ConsoleColor.Cyan, 1);
    }
}