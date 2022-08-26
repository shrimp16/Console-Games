class Program
{

    public static string answer { get; set; }
    public static int tries { get; set; }
    public static string[] words;
    public static Random random;

    static void Main(string[] args)
    {
        tries = 6;
        random = new Random();
        answer = getRandomWord();

        Console.WriteLine(answer);

        Console.Clear();

        Console.WriteLine("Welcome to Wordle!\n");

        Console.WriteLine("\nHere's how the game works:");

        Console.WriteLine("\nYou will have to write a word with 5 letters to try to guess an hidden word!");

        Console.WriteLine("\nYou will have 6 tries!");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nGreen - Means the word is in it's correct place!");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nYellow - The word contains that letter atleast once, but it's not in the right place!");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nRed - The word does not contain that letter!");

        Console.ForegroundColor = ConsoleColor.White;

        guessWord();
    }

    public static string getRandomWord()
    {
        words = File.ReadAllLines("./words.txt");

        return words[random.Next(words.Length)];
    }

    public static void guessWord()
    {
        Console.Write("\nYour guess: ");
        string? userAnswer = Console.ReadLine();


        Console.WriteLine("\n================================\n");

        if (userAnswer == null || userAnswer.Length != 5 || !words.Contains(userAnswer))
        {
            Console.WriteLine("Invalid word!");
            guessWord();
        }

        tries--;

        showCorrectness(userAnswer);

        Console.WriteLine("\n================================");

        if (tries < 0)
        {
            Console.WriteLine("The word is {0}, you lost!", answer);
            return;
        }

        if (userAnswer == answer)
        {
            Console.WriteLine("The word is {0}, you won!", answer);
            return;
        }

        else
        {
            guessWord();
        }

    }

    public static void showCorrectness(string userAnswer)
    {
        string[] correctness = new string[5];

        for (int i = 0; i < 5; i++)
        {
            switch (checkLetter(userAnswer[i], i))
            {
                case 0:
                    correctness[i] = "Wrong";
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    correctness[i] = "Correct";
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    correctness[i] = "Wrong Place";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.WriteLine("Letter {0}: {1}", userAnswer[i], correctness[i]);


            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine("\n================================\n");

        Console.WriteLine("Tries left: {0}", tries);
    }

    public static int checkLetter(char letter, int currentLetter)
    {
        if (!answer.Contains(letter))
        {
            return 0;
        }

        if (letter == answer[currentLetter])
        {
            return 1;
        }

        return 2;
    }
}