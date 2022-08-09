using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira a frase que você deseja traduzir para morse: ");
            string input = Console.ReadLine();
            input = input.ToUpper();
            char[] translation = input.ToCharArray();
            string output = "";

            foreach(char c in translation)
            {
                output = output + Dictionary._textToMorse[c] + " ";                
            }

            Console.WriteLine("Código morse: " + output);

            Console.ReadKey();
        }
    }
}
