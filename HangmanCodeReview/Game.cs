using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;
using HangmanCodeReview.Factories;
using System.Text.RegularExpressions;


namespace HangmanCodeReview
{
    public class Game : IGame
    {

        public void StartGame()
        {
            var randomWord = FactoryOne.Resolve<IWordGenerator>();
            var hangmanVisual = FactoryOne.Resolve<IHangmanVisual>();
            var life = FactoryOne.Resolve<ILives>();
            var gameover = FactoryOne.Resolve<IGameOverScreen>();
            var lifeText = FactoryOne.Resolve<IWrongGuessPrompt>();
            var duplicateGuess = FactoryOne.Resolve<IDuplicateGuess>();

            var guessedLetters = new List<char>();

            var lives = life.NumberOfLives();
            var wordToGuess = randomWord.Generate();
            var guessedWord = new string('_', wordToGuess.Length).ToCharArray();

            while (lives >= 0 && new string(guessedWord) != wordToGuess)
            {
                Console.Clear();
                Console.WriteLine("\nOrdet: " + new string(guessedWord));
                Console.WriteLine("Gissade bokstäver: " + string.Join(", ", guessedLetters));
                Console.WriteLine($"Liv kvar: {lives}");
                hangmanVisual.Visualize(lives);
                Console.Write("Gissa en bokstav: ");

                char guess = Console.ReadLine().ToLower()[0];

                Console.WriteLine(duplicateGuess.PrintsIfDuplicate(guessedLetters, guess));

                //Om 

                guessedLetters.Add(guess);

                if (wordToGuess.Contains(guess))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedWord[i] = guess;
                        }
                    }
                    Console.WriteLine("Rätt gissat! Tryck för att gissa igen.");
                    Console.ReadLine();
                }
                else
                {
                    lives--;
                    Console.WriteLine(lifeText.LivesOutputText(lives));
                    Console.ReadLine();
                }                
            }
        }
    }
}
