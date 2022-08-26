class Program
{

    public static string answer { get; set; }
    public static int tries { get; set; }

    public static int languageId { get; set; }
    public static string[] words;
    public static Random random;

    public static string[] files = { "en", "es", "fr" };

    public static string[] win = { "The word is {0}, you won!", "La palabra es {0}, ganaste", "Le mot est {0}, tu as gagné!" };
    public static string[] lost = { "The word is {0}, you lost!", "La palabra es {0}, perdiste", "Le mot est {0}, tu as perdu!" };
    public static string[] tries_view = { "Tries left: ", "Intentos restantes: ", "Tentatives restantes: " };

    static void Main(string[] args)
    {
        tries = 6;
        random = new Random();
        answer = getRandomWord();

        Menu menu = new Menu();

        languageId = menu.Start();

        Console.Clear();

        Console.WriteLine(Messages.START[languageId]);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Messages.GREEN[languageId]);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Messages.YELLOW[languageId]);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Messages.RED[languageId]);

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(answer);

        guessWord();
    }

    public static string getRandomWord()
    {
        words = File.ReadAllLines($"./words/{files[languageId]}.txt");

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
            Console.WriteLine("\n================================\n");
            guessWord();
        }

        tries--;

        showCorrectness(userAnswer);

        Console.WriteLine("\n================================");

        if (userAnswer == answer)
        {
            Console.WriteLine();
            Console.WriteLine(win[languageId], answer);
            Console.WriteLine("\n================================\n");
            return;
        }

        if (tries == 0)
        {
            Console.WriteLine();
            Console.WriteLine(lost[languageId], answer);
            Console.WriteLine("\n================================\n");
            return;
        }

        Console.WriteLine();
        Console.WriteLine(tries_view[languageId] + tries);
        Console.WriteLine("\n================================");

        guessWord();


    }

    public static void showCorrectness(string userAnswer)
    {
        string[] correctness = new string[5];

        for (int i = 0; i < 5; i++)
        {
            switch (checkLetter(userAnswer[i], i))
            {
                case 0:
                    correctness[i] = Messages.WRONG[languageId];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    correctness[i] = Messages.CORRECT[languageId];
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    correctness[i] = Messages.CORRECT[languageId];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.WriteLine("{0} : {1}", userAnswer[i], correctness[i]);

            Console.ForegroundColor = ConsoleColor.White;
        }
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