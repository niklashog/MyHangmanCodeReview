using HangmanCodeReview.Interfaces;
using HangmanCodeReview.Factories;

namespace HangmanCodeReview
{
    public class Application(
        IWelcomeMessage welcomeMessage)
    {
        public void Run()
        {
            var game = FactoryOne.Resolve<IGame>();

            Console.WriteLine(welcomeMessage.Print());
            Console.ReadKey();

            game.Run();
        }
    }
}
