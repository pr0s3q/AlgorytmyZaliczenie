using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyZaliczenie
{
    internal class Validation
    {
        public static void BracketValidation(string toValidate)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>
            {
                {'"',"doubleStraight"},         // "
                {'\u0027',"singleStraight"},    // '
                {'|',"singleLong"}              // |
            };
            Dictionary<string, char> charDictionary = new Dictionary<string, char>
            {
                {"doubleStraight", '"'},         // "
                {"singleStraight", '\u0027'},    // '
                {"singleLong", '|'}              // |
            };
            Stack<string> brackets = new Stack<string>();
            foreach (char char_ in toValidate)
            {
                if (brackets.Count == 0)
                {
                    brackets.Push(dictionary[char_]);
                }
                else
                {
                    if (brackets.Peek() == dictionary[char_])
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        brackets.Push(dictionary[char_]);
                    }
                }
            }
            if (brackets.Count == 0)
            {
                Console.WriteLine("Brackets closed correct");
            }
            else
            {
                Console.WriteLine("Brackets closed incorrectly. Close this bracket: ");
                foreach(string char_ in brackets)
                {
                    Console.WriteLine($"{charDictionary[char_]} {char_}");
                }
            }
        }
    }
}
