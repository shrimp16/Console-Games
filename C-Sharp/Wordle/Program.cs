class Program
{

    public static string answer { get; set; }
    public static int guesses { get; set; }
    public static Random random;

    static void Main(string[] args)
    {
        guesses = 6;
        random = new Random();
        answer = getRandomWord();

        Console.WriteLine(answer);

        Console.WriteLine("Welcome to Wordle!\nTry to guess the word!");

        guessWord();
    }

    public static string getRandomWord()
    {
        string[] words = File.ReadAllLines("./words.txt");

        return words[random.Next(words.Length)];
    }

    public static void guessWord()
    {

        string? userAnswer = Console.ReadLine();

        guesses--;

        Console.WriteLine("================================\n");

        if (userAnswer == null || userAnswer.Length != 5)
        {
            Console.WriteLine("Invalid word!");
            guessWord();
        }

        showCorrectness(userAnswer);

        Console.WriteLine("\n================================");

        if (guesses == 0)
        {
            Console.WriteLine("The word is {0}, you lost!", answer);
            return;
        }

        if (userAnswer == answer)
        {
            Console.WriteLine("The word is {0}, you won and still had {1} guesses left!", answer, guesses);
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
                    break;
                case 1:
                    correctness[i] = "Correct";
                    break;
                case 2:
                    correctness[i] = "Wrong Place";
                    break;
            }

            Console.WriteLine("Letter {0}: {1}", userAnswer[i], correctness[i]);
        }
    }

    public static int checkLetter(char letter, int currentLetter)
    {
        if (!answer.Contains(letter))
        {
            return 0;
        }

        if (answer.Contains(letter) && letter == answer[currentLetter])
        {
            return 1;
        }

        return 2;
    }
}