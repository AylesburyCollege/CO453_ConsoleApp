using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.Unit4
{
    class TestBook
    {
        public static void Test()
        {
            Book myBook = new Book()
            {
                Author = "Derek",
                Title = "My Horror Story",
                Weapon = "Cross Bow",
                Name = "Beyonce",
                Gender = GenderTypes.FEMALE
            };


            myBook.GetDetails();
            myBook.WriteChapter(1);
        }
    }
}
