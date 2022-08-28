class Menu
{

    public static string[] languages = { "English", "Português", "Español", "Français"};
    

    public static string languageSelected { get; set; }

    public static bool selected { get; set; }
    public static int position { get; set; }

    public int Start()
    {

        position = 0;

        loadMenu();

        useMenu();

        return position;

    }

    public void loadMenu()
    {
        Console.Clear();

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

    public void useMenu()
    {
        while (!selected)
        {
            keyPress(Console.ReadKey(true).Key);
        }
    }

    public void keyPress(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (position == 0)
                {
                    break;
                }
                position--;
                loadMenu();
                break;
            case ConsoleKey.DownArrow:
                if (position == languages.Length - 1)
                {
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
}