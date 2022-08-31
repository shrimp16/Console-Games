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
        Play();
    }

    public void Play()
    {
        int guess;

        while (!win)
        {
            Console.WriteLine("Guess a number: ");
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
            Console.WriteLine($"Congratulations! You won within {tries} tries");
            win = true;
            return;
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("Wrong! Too low!");
            return;
        }

        Console.Write("Wrong! Too high!");
    }

}