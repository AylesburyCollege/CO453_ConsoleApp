using System;

namespace CO453_ConsoleApp.SPS
{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the SPS Game
    /// </summary>
    public class GameInterface
    {
        public static string Title = "Scissors-Paper-Stone Game";

        public const int MAXN_TURNS = 3;

        private static string playerName = "Derek";

        private static int turn;

        public static void RunGame()
        {
            SetupScreen();
            StartGame();

            for(turn = 1; turn <= MAXN_TURNS; turn++)
            {
                GetPlayerChoice();
                Game.GetComputerChoice();

                ShowChoices();

                Game.WorkoutWinner();
                ShowResult();

                Console.WriteLine();
                Console.Write("Press any key!");
                Console.ReadKey();
            }

            Game.End();
            EndGame();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void EndGame()
        {
            Console.Clear();
            UserLib.WriteTitle(Title);

            Console.WriteLine("The overall winner is " + Game.Winner);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void GetPlayerChoice()
        {
            Console.Clear();
            UserLib.WriteTitle(Title);

            Console.WriteLine("Turn no " + turn + " of " + MAXN_TURNS);

            string[] choices = new string [] { Game.SCISSORS, Game.PAPER, Game.STONE };
            int choiceNo = UserLib.GetChoice(choices);
            Game.PlayerChoice = choices[choiceNo - 1];

            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void DrawChoice(Players player)
        {
            string choice;
            int x;
            int y = 12;

            if (player == Players.COMPUTER)
            {
                x = 50;
                choice = Game.ComputerChoice;
            }
            else
            {
                choice = Game.PlayerChoice;
                x = 5;
            }

            if (choice == Game.SCISSORS)
            {
                Images.DrawScissors(x, y);
            }
            else if (choice == Game.PAPER)
            {
                Images.DrawPaper(x, y);
            }
            else if (choice == Game.STONE)
            {
                Images.DrawStone(x, y);
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void ShowChoices()
        {
            DrawChoice(Players.PLAYER);
            DrawChoice(Players.COMPUTER);

            Console.WriteLine("\n\tYou picked " + Game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + Game.ComputerChoice);
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void ShowResult()
        {
            Console.WriteLine("\tThe current winner is the " + Game.Winner);
            Console.WriteLine();
            Console.WriteLine("\tThe player has won " + Game.PlayerScore + " times");
            Console.WriteLine("\tThe computer has won " + Game.ComputerScore + " times");
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void SetupScreen()
        {
            Console.Title = Title;

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void StartGame()
        {
            UserLib.WriteTitle(Title);
            Game.Start();
            playerName = UserLib.GetString("Please enter your name > ");
        }
    }
}
