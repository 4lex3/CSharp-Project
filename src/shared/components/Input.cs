public class Input
{

    public static int SelectInput(string label, List<string> options, ConsoleColor color = ConsoleColor.DarkCyan)
    {
        int value = 0;
        Console.ForegroundColor = color;

        Console.WriteLine($"{label} 👀 \n");
        for (int i = 0; i < options.Count; i++) Console.WriteLine($"   {i + 1}. {options[i]} \n");

        Console.Write($"Select your option: "); value = int.Parse(Console.ReadLine()!);
        if (value <= 0 || value > options.Count) throw new IndexOutOfRangeException("Option not found");

        Console.ResetColor();
        return value;
    }

    


    public static string TextInput(string label, ConsoleColor consoleColor = ConsoleColor.DarkBlue)
    {

        string value;


        while (true)
        {
            try
            {
                Dialog.WriteDialog($"{label}", consoleColor); value = Console.ReadLine()!;
                if(value == "") throw new NullReferenceException("This value is not empty! ");
                return value;
            }
            catch (NullReferenceException e)
            {
                Dialog.WriteDialog(e.Message, ConsoleColor.Red);
                Console.ReadKey();
            }
        }

    }
}