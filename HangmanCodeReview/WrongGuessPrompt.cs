using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview
{
    public class WrongGuessPrompt : IWrongGuessPrompt
    {
        public string LivesOutputText(int lives)
        {
            switch (lives)
            {
                case 0:
                    return "Det var sista gissningen. Bättre lycka nästa gång!";
                case 1:
                    return "Du har bara en gissning kvar! Kom igen!";
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Fel gissat! Du förlorade ett liv. Tryck för att gissa igen.";
                default:
                    return "Hur fick du så här många liv? Magic!";
            }
        }
    }
}
