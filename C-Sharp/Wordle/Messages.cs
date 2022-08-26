class Messages
{
    public static readonly string START_ENGLISH = "Welcome to Wordle!\n"
    + "\nHere's how the game words:\n"
    + "\nYou will have to write a word with 5 letters to try to guess an hidden word!\n"
    + "\nYou will have 6 tries!\n";
    public static readonly string START_SPANISH = "Bienvenido(a) a Wordle\n"
    + "\nAsí es como functiona el juego:\n"
    + "\nTendrás que escribir una palabra de 5 letras para intentar adivinar la palabra oculta!\n"
    + "\nTentrás 6 intentos!";
    public static readonly string START_FRENCH = "Bienvenue sur Wordle\n"
    + "\nVoici comment fonctionne le jeu:\n"
    + "\nVous devrez écrire un mot de 5 lettres pour tenter de devine le mot chaché\n"
    + "\nVous aurez 6 essais";
    public static readonly string[] START = { START_ENGLISH, START_SPANISH, START_FRENCH };
    public static readonly string GREEN_ENGLISH = "\nGreen - Means the word is in it's correct place!";
    public static readonly string RED_ENGLISH = "\nRed - The secret word does not contain that letter!";
    public static readonly string YELLOW_ENGLISH = "\nYellow - The secret word contains that letter atleast once, but it's not in the right place!";
    public static readonly string GREEN_SPANISH = "\nVerde - significa que la palabra está en su lugar correcto.";
    public static readonly string RED_SPANISH = "\nRojo - La palabra secreta no contiene esa letra";
    public static readonly string YELLOW_SPANISH = "\nAmarillo - la palabra secreta contiene esa letra al menos una vez, pero no está en el lugar correcto";
    public static readonly string GREEN_FRENCH = "\nVert - Signifie que le mot est à sa place";
    public static readonly string RED_FRENCH = "\nRouge - Le mot secret ne contient pas cette lettre";
    public static readonly string YELLOW_FRENCH = "\nJaune - Le mot secret contient cette lettre au moins une fois, mais ce n'est pas au bon endroit";
    public static readonly string[] GREEN = { GREEN_ENGLISH, GREEN_SPANISH, GREEN_FRENCH };
    public static readonly string[] RED = { RED_ENGLISH, RED_SPANISH, RED_FRENCH };
    public static readonly string[] YELLOW = { YELLOW_ENGLISH, YELLOW_SPANISH, YELLOW_FRENCH };
    public static readonly string[] WRONG = { "Wrong", "Equivocado", "Mauvais" };
    public static readonly string[] CORRECT = { "Correct", "Correcto", "Corriger" };
    public static readonly string[] WRONG_PLACE = { "Wrong Place", "Lugar Equivocado", "Mauvais Endroit" };

}