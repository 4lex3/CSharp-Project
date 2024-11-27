public class Input
{

    public static int SelectInput(string label, List<string> options)
    {
        int value = 0;
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine($"{label} 👀 \n");
        for (int i = 0; i < options.Count; i++) Console.WriteLine($"   {i + 1}. {options[i]} \n");

        Console.Write($"Select your option: "); value = int.Parse(Console.ReadLine()!);
        if(value <= 0 || value > options.Count ) throw new IndexOutOfRangeException("Option not found");

        Console.ResetColor();
        return value;
    }


    public static string TextInput(string label)
    {
        string value;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"{label} 😱 "); value = Console.ReadLine()!;
        Console.ResetColor();

        return value;
    }

}