using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview.GameLogic
{
    public class WordGenerator : IWordGenerator
    {
        public string Generate()
        {
            var random = new Random();
            string[] words = { "programmering", "utveckling", "lärande", "teknik", "dator" };
            string wordToGuess = words[random.Next(words.Length)];
            return wordToGuess;
        }
    }
}
