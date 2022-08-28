class Messages
{
    public static readonly string START_ENGLISH = "Welcome to Wordle!\n"
    + "\nHere's how the game words:\n"
    + "\nYou will have to write a word with 5 letters to try to guess an hidden word!\n"
    + "\nYou will have 6 tries!\n";
    public static readonly string START_PORTUGUESE = "Bem-vindo(a) ao Wordle\n"
    + "\nO jogo funciona assim:\n"
    + "\nVocê terá que escrever uma palavra com 5 letras para tentar adivinhar a palavra secrete!\n"
    + "\nVocê terá 6 tentativas\n";
    public static readonly string START_SPANISH = "Bienvenido(a) a Wordle\n"
    + "\nAsí es como functiona el juego:\n"
    + "\nTendrás que escribir una palabra de 5 letras para intentar adivinar la palabra oculta!\n"
    + "\nTentrás 6 intentos!";
    public static readonly string START_FRENCH = "Bienvenue sur Wordle\n"
    + "\nVoici comment fonctionne le jeu:\n"
    + "\nVous devrez écrire un mot de 5 lettres pour tenter de devine le mot chaché\n"
    + "\nVous aurez 6 essais";
    public static readonly string[] START = { START_ENGLISH, START_PORTUGUESE, START_SPANISH, START_FRENCH };
    public static readonly string GREEN_ENGLISH = "\nGreen - The letter is in it's correct place!";
    public static readonly string RED_ENGLISH = "\nRed - The secret word does not contain that letter!";
    public static readonly string YELLOW_ENGLISH = "\nYellow - The secret word contains that letter atleast once, but it's not in the right place!";
    public static readonly string GREEN_PORTUGUESE = "\nVerde - A letra está no sitio certo!";
    public static readonly string RED_PORTUGUESE = "\nVermelho - A palavra secreta não possui essa letra!";
    public static readonly string YELLOW_PORTUGUESE = "\nAmarelo - A palavra secreta contém essa letra pelo menos uma vez, mas ela está na posição errada!";
    public static readonly string GREEN_SPANISH = "\nVerde - significa que la letra está en su lugar correcto.";
    public static readonly string RED_SPANISH = "\nRojo - La palabra secreta no contiene esa letra";
    public static readonly string YELLOW_SPANISH = "\nAmarillo - la palabra secreta contiene esa letra al menos una vez, pero no está en el lugar correcto";
    public static readonly string GREEN_FRENCH = "\nVert - Signifie que le lettre est à sa place";
    public static readonly string RED_FRENCH = "\nRouge - Le mot secret ne contient pas cette lettre";
    public static readonly string YELLOW_FRENCH = "\nJaune - Le mot secret contient cette lettre au moins une fois, mais ce n'est pas au bon endroit";
    public static readonly string[] GREEN = { GREEN_ENGLISH, GREEN_PORTUGUESE, GREEN_SPANISH, GREEN_FRENCH };
    public static readonly string[] RED = { RED_ENGLISH, RED_PORTUGUESE, RED_SPANISH, RED_FRENCH };
    public static readonly string[] YELLOW = { YELLOW_ENGLISH, YELLOW_PORTUGUESE, YELLOW_SPANISH, YELLOW_FRENCH };
    public static readonly string[] WRONG = { "Wrong", "Errado", "Equivocado", "Mauvais" };
    public static readonly string[] CORRECT = { "Correct", "Correto", "Correcto", "Corriger" };
    public static readonly string[] WRONG_PLACE = { "Wrong Place", "Sitío Errado", "Lugar Equivocado", "Mauvais Endroit" };

}