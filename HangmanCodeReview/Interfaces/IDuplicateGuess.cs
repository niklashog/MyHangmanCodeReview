using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Interfaces
{
    public interface IDuplicateGuess
    {
        public string PrintsIfDuplicate(List<char> guessedLetters, char guess);
    }
}
