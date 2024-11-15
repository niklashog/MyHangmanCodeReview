using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Factories;

namespace HangmanCodeReview.Messages
{
    public class DuplicateGuess : IDuplicateGuess
    {
        public string PrintsIfDuplicate(List<char> guessedLetters, char guess)
        {
            if (guessedLetters.Contains(guess))
            {
                return "Du har redan gissat den bokstaven. Försök igen.";
            }
            else
            {
                return null;
            }
        }
    }
}