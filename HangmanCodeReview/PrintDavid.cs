using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview
{
    public class PrintDavid : IPrintDavid
    {
        public string Print()
        {
            return @"
Absolut! Här är ett försök att rita något som liknar David Hasselhoff i ASCII-art:

       ____________
      /            \
     /   /~~~~\     \
    |   |      |    |
    |   |      |    |
    |   \______/    |
    \              /
     \____________/
          ||
         /  \
        /____\
       /      \
      /        \
     /          \

Observera att det är en förenklad illustration och kanske inte fångar hans exakta utseende, 
men jag hoppas att det ger en ungefärlig bild!
";
        }
    }
}
