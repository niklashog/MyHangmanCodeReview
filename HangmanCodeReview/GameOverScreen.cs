using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview
{
    public class GameOverScreen : IGameOverScreen
    {
        public string Print()
        {
            return @"
                ------
                |
                | Game
                | Over
                |
                ------
                ";
        }
    }
}