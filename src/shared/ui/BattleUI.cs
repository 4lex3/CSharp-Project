public class BattleUI
{

    public static void PlayerStatusBar(Helen helen, Sean sean, Enemy enemy)
    {

        Console.ForegroundColor = ConsoleColor.Green;


        Console.WriteLine($"\t\t\t Helen: {helen.Health} ❤️      Sean: {sean.Health} ❤️  {sean.GetCurrentEnergyPoints()}       {enemy.CharacterName} (Enemy): {enemy.Health} ❤ \n");
        Console.WriteLine($"-------------------------------------- Health / Points ----------------------------------------");
        Console.ResetColor();

    }

    public static void AttackLogBar(List<string> attackLog)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n\n");

        if (attackLog.Count > 0)
        {
            foreach (string log in attackLog)
            {
                Console.WriteLine($"\t\t\t{log}");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine($"-------------------------------------- Attack Logs ----------------------------------------");
            Console.WriteLine("\n\n");
        }

        Console.ResetColor();
    }

    public static void GameOverMessage()
    {

        Dialog.WriteDialog(@"
            
               

                    ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
                    ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
                    ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
                    ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
                    ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
                    ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
                    ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
                    ░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
                        ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                                        ░                   

            ", ConsoleColor.Red, 1);


    }

    public static void VictoryMessage()
    {

        Dialog.WriteDialog(@"
            
               


                    ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗
                    ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║
                    ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║
                    ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║
                    ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║
                    ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝
                                                      
            
            ", ConsoleColor.Green, 1);

    }


    public static void PlayerStatsTable(Player player)
    {

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("\n\n\n\n\t\t\tYour stats: \n\n\n\n\n\n");

        Console.WriteLine("\t\t\t\t+--------------------+----------------------+");
        Console.WriteLine("\t\t\t\t|       Field        |       Value          |");
        Console.WriteLine("\t\t\t\t+--------------------+----------------------+");
        Console.WriteLine($"\t\t\t\t| Name               | {player.Name,-20} |");
        Console.WriteLine($"\t\t\t\t| CurrentLevel       | {player.CurrentLevel,-20} |");
        Console.WriteLine($"\t\t\t\t| Attempts           | {player.Attempts,-20} |");
        Console.WriteLine($"\t\t\t\t| Time Played        | {player.TimePlayed,-20} |");
        Console.WriteLine($"\t\t\t\t| Initial Date       | {player.InitialDate,-20} |");
        Console.WriteLine($"\t\t\t\t| In Progress        | {player.InProgress,-20} |");
        Console.WriteLine("\t\t\t\t+--------------------+----------------------+");


        Console.ReadKey();
        Console.ResetColor();
    }



}