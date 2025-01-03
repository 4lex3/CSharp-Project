public class Dialog
{

    public static void WriteDialog(string text, ConsoleColor textColor = ConsoleColor.Green, int sleep = 10)
    {

        Console.ForegroundColor = textColor;

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write($"{text[i]}");
            Thread.Sleep(sleep);
        }

        Console.ResetColor();
    }
}