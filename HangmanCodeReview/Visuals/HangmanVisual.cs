using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview.Visuals
{
    public class HangmanVisual : IHangmanVisual
    {
        public void Visualize(int lives)
        {
            switch (lives)
            {
                case 6:
                    Console.WriteLine(@"
                ------
                |   |
                |
                |
                |
                |
                -------
                ");
                    break;
                case 5:
                    Console.WriteLine(@"
                ------
                |   |
                |   o
                |
                |
                |
                -------
                ");
                    break;
                case 4:
                    Console.WriteLine(@"
                ------
                |   |
                |   o
                |   |
                |
                |
                -------
                ");
                    break;
                case 3:
                    Console.WriteLine(@"
                ------
                |   |
                |   o
                |   |\
                |
                |
                -------
                ");
                    break;
                case 2:
                    Console.WriteLine(@"
                ------
                |   |
                |   o
                |   |\
                |  /
                |
                -------
                ");
                    break;
                case 1:
                    Console.WriteLine(@"
                ------
                |   |
                |   o
                |  /|\
                |  /
                |
                -------
                ");
                    break;
                case 0:
                    Console.WriteLine(@"
                ------
                |   |
                |   o   
                |  /|\  Game
                |  / \  Over
                |
                ------
                ");
                    break;
                default:
                    break;
            }
        }
    }
}
