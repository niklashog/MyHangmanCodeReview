using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview.Messages
{
    public class WelcomeMessage : IWelcomeMessage
    {
        public string Print()
        {
            string message =
                "Välkommen till Hänga gubbe!\n" +
                "Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.\n" +
                "Tryck valfri tangent för att börja spela";
            return message;
        }
    }
}
