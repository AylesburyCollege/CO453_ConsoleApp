using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp
{
    class MP3TopTen
    {
        private string[] topTen = new string[] 
            {
                "Sweet but Psycho",
                "7 Rings",
                "Swan Song",
                "Nothing Breaks Like a Heart",
                "Baby",
                "Dancing with a Stranger",
                "Rewrite the Stars",
                "Without Me",
                "Perfect to Me",
                "Giant"
            };

        public static void Main()
        {
            MP3TopTen chart = new MP3TopTen();

            chart.Show();
            chart.GetVote();

            Console.ReadKey();
        }

        public void Show()
        {
            Console.Clear();
            UserLib.WriteTitle("Top Ten MP3");

            int i = 0;
            foreach(string song in topTen)
            {
                i++;
                Console.WriteLine("\tSong Title " + i + ": " + song);
            }
        }

        public void GetVote()
        {
            int vote = UserLib.GetInt("Choose 1 - " + topTen.Count() + " > ");
        }
    }
}
