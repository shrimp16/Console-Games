class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }

}

class Game
{
    public int randomNumber { get; set; }
    public int tries { get; set; }
    public bool win { get; set; }

    public void Start()
    {
        randomNumber = GenerateRandomNumber();
        Console.Clear();
        Play();
    }

    public void Play()
    {
        int guess;

        while (!win)
        {
            Console.Write("Guess a number: ");
            Int32.TryParse(Console.ReadLine(), out guess);
            tries++;
            CheckNumber(guess);
        }

    }

    public int GenerateRandomNumber()
    {
        return new Random().Next(100);
    }

    public void CheckNumber(int guess)
    {

        if (guess == randomNumber)
        {
            Console.WriteLine($"\nCongratulations! You won within {tries} tries");
            win = true;
            return;
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("Wrong! Too low!\n");
            Console.WriteLine(new string('=', 20));
            return;
        }

        Console.WriteLine("Wrong! Too high!\n");
        Console.WriteLine(new string('=', 20));
    }

}