using System;

namespace CO453_ConsoleApp
{
    class Tournament
    {
        private int[] scores;
        public const int MAXN_SCORES = 6;

        public static void Main()
        {
            UserLib.WriteTitle("5.1 Tournament Scores");
            Tournament myTournament = new Tournament();
            myTournament.GetScores();
        }

        public Tournament()
        {
            scores = new int[MAXN_SCORES];
        }

        public void GetScores()
        {
            for(int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter score " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
