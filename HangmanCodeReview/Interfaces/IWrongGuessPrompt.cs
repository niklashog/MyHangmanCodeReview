﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Interfaces
{
    public interface IWrongGuessPrompt
    {
        public string LivesOutputText(int lives);
    }
}
