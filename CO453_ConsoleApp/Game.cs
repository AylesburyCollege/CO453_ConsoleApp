using System;

namespace CO453_ConsoleApp
{
    /// <summary>
    /// This class plays ...
    /// Author: 
    /// Started: 
    /// </summary>
    class Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "PAPER";
        public const string PAPER = "STONE";

        string computerChoice;
        string playerChoice;

        Random randomGenerator;

        static void Main()
        {
            Game myGame = new Game();  // create new Game object
            myGame.Play();             // call its play method
        }

        /// <summary>
        /// *******************************************************
        /// Create a new random number generator object
        /// *******************************************************
        /// </summary>
        public Game()
        {
            randomGenerator = new Random();       // create new Random object
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void Play()
        {
            SetupScreen();
            Start();

            GetPlayerChoice();
            GetComputerChoice();

            DrawPlayerChoice();

            ShowChoices();
            ShowResult();

            Console.ReadKey();   // wait for a key press
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void SetupScreen()
        {
            Console.Title = " The Great Scissors-Paper-Stone Game";

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void Start()
        {
            Console.WriteLine("\tPlay the Scissors Paper Stone Game");
            Console.WriteLine("\t==================================");
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void GetPlayerChoice()
        {
            Console.WriteLine("\n\tWhat is your choice ?");
            Console.Write("\tScissors Paper or Stone : ");

            playerChoice = Console.ReadLine();
            playerChoice = playerChoice.ToUpper();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void GetComputerChoice()
        {
            int num;
            num = randomGenerator.Next(3);  // pick a random number (0, 1 or 2)
            if (num == 0)
            {
                computerChoice = SCISSORS;
            }
            else
            {
                computerChoice = "NOT YET DETERMINED";
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowChoices()
        {
            Console.WriteLine("\n\t You picked " + playerChoice);
            Console.WriteLine("\tThe computer choice is " + computerChoice);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowResult()
        {
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("\n\tA DRAW!!");
            }
            else
            {
                Console.WriteLine("\n\n\t Result not yet Determined !!!");
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawPlayerChoice()
        {
            if (playerChoice == SCISSORS)
            {
                DrawScissors(10, 5);
            }
            else if (playerChoice == PAPER)
            {
                DrawPaper(10, 5);
            }
            else if (playerChoice == STONE)
            {
                DrawStone(10, 5);
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawScissors(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   // set start position then increment y to move down
            Console.Write("     \\            /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      \\          /");
            Console.SetCursorPosition(x, y++);
            Console.Write("       \\        /");
            Console.SetCursorPosition(x, y++);
            Console.Write("        \\      /");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\    /");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("           **");
            Console.SetCursorPosition(x, y++);
            Console.Write("          /  \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    (----/    \\----)");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\  /      \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      ==        ==");
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawStone(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   // set start position then increment y to move down
            Console.Write("                 ___---___     ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              .--         --.    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           ./   ()       .-. \\.   ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           /   o    .   (   )  \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          / .            '-'    \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         /     ()   ()           \\ ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |    o           ()       | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |      .--.           O   | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\ .  |    |              |  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\   `.__.'     o   .   /    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           `\\  o    ()         /'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              `--___    ___--'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("                     ---         ");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawPaper(int x, int y)
        {
            Console.SetCursorPosition(x, y++);    // set start position then increment y to move down
            Console.Write("      .--.------------------.");
            Console.SetCursorPosition(x, y++);
            Console.Write("     /      \\  \\ \\ \\ \\ \\ \\ \\ \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    /   OOO  \\                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   || A N D R E X | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   |                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("    \\   OOO   /                /");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\      // / / / / / / / //");
            Console.SetCursorPosition(x, y++);
            Console.Write("       `--'-|| | | | | | | | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("             \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("              \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("               \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                \\ \\ \\ \\ \\ \\ \\ \\ \\\\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                 \\________________\\");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawSmile()
        {
            Console.WriteLine("\n                    .-\"\"\"\"-.-\"\"\"\"-. ");
            Console.WriteLine("               _.'`               `'._   ");
            Console.WriteLine("            .-'  __..,.___.___.,..__  '-.   ");
            Console.WriteLine("           '-.-;` |  |    |    |  | `;-.-'   ");
            Console.WriteLine("            \\'-\\_/\\__|    |    |__/\\_/-'/   ");
            Console.WriteLine("             \\, _     '---'---'     _ ,/   ");
            Console.WriteLine("              \\'./`'.--.--.--,--.'`\\.'/   ");
            Console.WriteLine("               \\ `'-;__|__|__|__;-'` /   ");
            Console.WriteLine("                '.                 .'   ");
            Console.WriteLine("                 `'-....---....-'`    ");
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawThumbsUp()
        {
            Console.WriteLine();
            Console.WriteLine("       _ ");
            Console.WriteLine("      ( ((  ");
            Console.WriteLine("       \\ =\\   ");
            Console.WriteLine("      __\\_ `-\\   ");
            Console.WriteLine("     (____))(  \\-----  ");
            Console.WriteLine("     (____)) _    ");
            Console.WriteLine("     (____))   ");
            Console.WriteLine("     (____))____/-----  ");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawThumbsDown()
        {
            Console.WriteLine();
            Console.WriteLine("       ______ ");
            Console.WriteLine("     ((____  \\-----  ");
            Console.WriteLine("     ((_____         ");
            Console.WriteLine("     ((_____      ");
            Console.WriteLine("     ((____   -----   ");
            Console.WriteLine("          /  /    ");
            Console.WriteLine("         (_((     ");
            Console.WriteLine();
        }
    }
}
