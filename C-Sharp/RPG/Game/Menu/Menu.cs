class Menu
{
    public string[] _content { get; set; }
    public int pointer { get; set; }
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
}