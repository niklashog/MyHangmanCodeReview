using HangmanCodeReview.Factories;

namespace HangmanCodeReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryOne.BuildContainer();
            new Application().Run();
        }
    }
}