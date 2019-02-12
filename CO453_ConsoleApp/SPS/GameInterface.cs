using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.SPS
{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the SPS Game
    /// </summary>
    public class GameInterface
    {
        public const int MAXN_TURNS = 3;

        private string playerName = "Derek";

        public static void RunGame()
        {
            SetupScreen();
            StartGame();

            GetPlayerChoice();

           
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void GetPlayerChoice()
        {
            Console.WriteLine("\n\tWhat is your choice ?");
            Console.Write("\tScissors Paper or Stone : ");

            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            Game.PlayerChoice = choice;

            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowChoices()
        {
            Console.WriteLine("\n\t You picked " + Game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + Game.ComputerChoice);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("\tThe winner is the " + Game.Winner);
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
            Console.Title = " The Great Scissors-Paper-Stone Game";

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
            Console.WriteLine("==================================");
            Console.WriteLine("Play the Scissors Paper Stone Game");
            Console.WriteLine("==================================");

            //playerName = UserLib.GetString("Please enter your name > ");
        }
    }
}
