public class Program {
    static public void Main(String[]args){
        Game game = new Game();
        game.Start();
    }
}

public class Game {
    public void Start(){
        Console.Clear();
        Console.WriteLine("Welcome to Console Rock Paper Scissors!");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey(true);
    }
}