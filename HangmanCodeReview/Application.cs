using HangmanCodeReview.Interfaces;
using HangmanCodeReview.Factories;

namespace HangmanCodeReview
{
    public class Application
    {
        public void Run()
        {
            var game = FactoryOne.Resolve<IGame>();
            var welcomeMessage = FactoryOne.Resolve<IWelcomeMessage>();

            Console.WriteLine(welcomeMessage.Print());
            Console.ReadKey();

            game.Run();
        }
    }
}
