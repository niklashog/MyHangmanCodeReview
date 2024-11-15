using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;
using HangmanCodeReview.Factories;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;


namespace HangmanCodeReview
{
    public class Game: IGame
    {
        private List<char> _guessedLetters;
        public Game()
        {
            _guessedLetters = new List<char>();
        }

        public void Run()
        {
            var randomWord = FactoryOne.Resolve<IWordGenerator>();
            var hangmanVisual = FactoryOne.Resolve<IHangmanVisual>();
            var life = FactoryOne.Resolve<ILives>();
            var gameover = FactoryOne.Resolve<IGameOverScreen>();
            var lifeText = FactoryOne.Resolve<IWrongGuessPrompt>();
            var duplicateGuess = FactoryOne.Resolve<IDuplicateGuess>();
            var victory = FactoryOne.Resolve<IVictory>();

            var lives = life.NumberOfLives();
            var wordToGuess = randomWord.Generate();
            var guessedWord = new string('_', wordToGuess.Length).ToCharArray();

            while (lives > 0 && new string(guessedWord) != wordToGuess)
            {
                Console.Clear();
                Console.WriteLine("\nOrdet: " + new string(guessedWord));
                Console.WriteLine("Gissade bokstäver: " + string.Join(", ", _guessedLetters));
                Console.WriteLine($"Liv kvar: {lives}");
                hangmanVisual.Visualize(lives);
                Console.Write("Gissa en bokstav: ");

                char guess = Console.ReadLine().ToLower()[0];

                Console.WriteLine(duplicateGuess.PrintsIfDuplicate(_guessedLetters, guess));

                _guessedLetters.Add(guess);

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
            Console.Clear();
            if (lives > 0)
            {
                victory.VictoryScreen();
            }
            else
            {
                hangmanVisual.Visualize(lives);
                Console.WriteLine($"Rätt ord var: {randomWord.Generate().ToString()}");
            }
        }
    }
}
