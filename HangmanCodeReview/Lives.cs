using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview
{
    public class Lives : ILives
    {
        public int NumberOfLives()
        {
            return 6;
        }
    }
}