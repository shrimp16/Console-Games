class Program
{

    public static string[] languages = { "English", "Portuguese", "German", "Spanish", "French", "Turkish" };

    public static string languageSelected;

    public static bool selected { get; set; }

    public static int position { get; set; }
    static void Main(string[] args)
    {

        position = 0;
        loadMenu();

        useMenu();
    }

    public static void useMenu()
    {

        while (!selected)
        {
            keyPress(Console.ReadKey(true).Key);
        }

        Console.WriteLine("You selected: {0}", languageSelected);

    }

    public static void keyPress(ConsoleKey key)
    {

        switch (key)
        {
            case ConsoleKey.UpArrow:
                if(position == 0){
                    break;
                }
                position--;
                loadMenu();
                break;
            case ConsoleKey.DownArrow:
                if(position == languages.Length - 1){
                    break;
                }
                position++;
                loadMenu();
                break;
            case ConsoleKey.Enter:
                languageSelected = languages[position];
                selected = true;
                break;

        }

    }

    public static void loadMenu()
    {

        Console.Clear();

        Console.WriteLine("Language:");

        for (int i = 0; i < languages.Length; i++)
        {
            if (i == position)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine(" - {0}", languages[i]);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}