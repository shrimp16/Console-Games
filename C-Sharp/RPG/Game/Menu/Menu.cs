class Menu
{
    public string[] _content { get; set; }
    public int pointer { get; set; }
    public bool selected { get; set; }
    public Menu(string[] content)
    {
        _content = content;
        pointer = 0;
    }

    public void Show()
    {
        Console.Clear();
        for (int i = 0; i < _content.Length; i++)
        {
            if (i == pointer)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine(_content[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public int GetOption()
    {
        while (selected == false)
        {
            KeyPress(Console.ReadKey(true).Key);
        }
        return pointer;
    }

    public void KeyPress(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (pointer - 1 < 0)
                {
                    return;
                }
                pointer--;
                break;
            case ConsoleKey.DownArrow:
                if (pointer + 1 >= _content.Length)
                {
                    return;
                }
                pointer++;
                break;
            case ConsoleKey.Enter:
                selected = true;
                break;
        }
        Show();
    }
}