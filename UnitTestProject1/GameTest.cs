using Microsoft.VisualStudio.TestTools.UnitTesting;
using CO453_ConsoleApp;

namespace UnitTestProject
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [Owner("Derek")]
        [TestCategory("Properties")]
        public void TestPlayerChoice()
        {
            Game.PlayerChoice = Game.PAPER;

            Assert.AreEqual(Game.PAPER, Game.PlayerChoice);
        }

        [TestMethod]
        [Owner("Derek")]
        [TestCategory("Properties")]
        public void TestComputerChoice()
        {
            Game.GetComputerChoice();
            string choice = Game.ComputerChoice;

            StringAssert.Contains(Game.PAPER+Game.SCISSORS+Game.STONE, choice);
        }

        [TestMethod]
        [Owner("Derek")]
        [TestCategory("Methods")]
        public void TestPaperStone()
        {
            Game.PlayerChoice = Game.PAPER;
            Game.ComputerChoice = Game.STONE;
            Game.WorkoutWinner();
           
            Assert.AreEqual(Game.Winner, Game.PlayerName);
        }

        [TestMethod]
        [Owner("Derek")]
        [TestCategory("Methods")]
        public void TestPlayerScore()
        {
            Game.Start();
            Game.PlayerChoice = Game.PAPER;
            Game.ComputerChoice = Game.STONE;
            Game.WorkoutWinner();

            Assert.AreEqual(Game.PlayerScore, 1);
        }
    }
}
