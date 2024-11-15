using HangmanCodeReview.Factories;
using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview
{
    public class Victory : IVictory
    {
        public void VictoryChoice()
        {
            var pamela = FactoryOne.Resolve<IPrintPamela>();
            var david = FactoryOne.Resolve<IPrintDavid>();

            Console.WriteLine("Bra jobbat! Du vann!");
            Console.WriteLine("Priset är en bild av Pamela eller David. Gör ditt val nedan:");
            Console.WriteLine("1. Pamela");
            Console.WriteLine("2. David");
            string davidorpamela = Console.ReadLine();
            switch (davidorpamela)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(pamela.Print());
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(david.Print());
                    break;
                default:
                    Console.WriteLine("Försök igen med korrekt siffra");
                    break;
            }
        }
    }
}
