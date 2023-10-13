using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabate;
            Console.WriteLine("Enter any alphabate :");
            alphabate = Console.ReadLine();
            if (alphabate == "a" || alphabate == "e" || alphabate == "i" || alphabate == "o" || alphabate == "u")
            {
                Console.WriteLine("The alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }
            Console.ReadKey();


        }
    }
}
