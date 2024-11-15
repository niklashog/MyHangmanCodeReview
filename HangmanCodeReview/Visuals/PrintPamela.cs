using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Visuals
{
    public class PrintPamela : IPrintPamela
    {
        public string Print()
        {
            return @"
'Okej, jag ska försöka rita något som liknar henne i ASCII-art:'

       ____________
      /            \
     |   /\    /\   |
     |  (  )  (  )  |
     |     /\       |
     |    ____      |
      \            /
       \__________/
          |    |
        __|    |__
       (          )
        ----------

'Hoppas du gillar det!'
";
        }
    }
}
