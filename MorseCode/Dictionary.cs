using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    internal class Dictionary
    {
        public static Dictionary<char, string> _textToMorse = new Dictionary<char, string>()
            {
              {' ', "/"},
              {'A', ".-"},
              {'B', "-..."},
              {'C', "-.-."},
              {'D', "-.."},
              {'E', "."},
              {'F', "..-."},
              {'G', "--."},
              {'H', "...."},
              {'I', ".."},
              {'J', ".---"},
              {'K', "-.-"},
              {'L', ".-.."},
              {'M', "--"},
              {'N', "-."},
              {'O', "---"},
              {'P', ".--."},
              {'Q', "--.-"},
              {'R', ".-."},
              {'S', "..."},
              {'T', "-"},
              {'U', "..-"},
              {'V', "...-"},
              {'W', ".--"},
              {'X', "-..-"},
              {'Y', "-.--"},
              {'Z', "--.."},
              {'1', ".----"},
              {'2', "..---"},
              {'3', "...--"},
              {'4', "....-"},
              {'5', "....."},
              {'6', "-...."},
              {'7', "--..."},
              {'8', "---.."},
              {'9', "----."},
              {'0', "-----"},
            };

        public static string StringToMorse(char[] input)
        {
            string output = "";
            foreach (char c in input)
            {
                output = output + Dictionary._textToMorse[c] + " ";
            }

            return output;
        }

    }
}
