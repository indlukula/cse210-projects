 public class Menu
{
    private Game WordGuessingGame;
    private List<Player> _players;
    private bool _gamePaused;
    
     public Menu()
    {
        _players = new List<Player>();
        _gamePaused = false;
    }
     public void Start()
    {
        Console.WriteLine("Welcome to the Word Guessing Game!");
         while (true)
        {
            Console.WriteLine("\n1. Guess Word:");
            Console.WriteLine("2. Pause Game");
            Console.WriteLine("3. Quit Game");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
             switch (choice)
            {
                case 1:
                    _gamePaused = false;
                    break;
                case 2:
                    _gamePaused = true;
					Console.WriteLine("Game paused. Press any key to resume.");
					Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Game quit: Thank you for playing!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}