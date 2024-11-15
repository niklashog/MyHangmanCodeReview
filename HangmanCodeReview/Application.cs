using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Factories;

namespace HangmanCodeReview
{
    public class Application
    {
        public void Run()
        {
            var welcomeMessage = FactoryOne.Resolve<IWelcomeMessage>();
            var gameOver = FactoryOne.Resolve<IGameOverScreen>();

            var game = FactoryOne.Resolve<IGame>();

            Console.WriteLine(welcomeMessage.Print());
            Console.ReadKey();

            game.StartGame();
        }
    }
}
