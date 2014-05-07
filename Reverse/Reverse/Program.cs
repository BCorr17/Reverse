using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    class Program
    {
        public static string Reverse(string input)
        {
            string output = "";

            char[] seq = input.ToCharArray();

            Array.Reverse(seq);

            string final = new string(seq);
            input = final;
            return input;

            //return output;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string:");

            string input = Console.ReadLine();
            string output = Reverse(input);
            //string output = Reverse(Console.ReadLine));

            Console.WriteLine(output);
        }
    }
}
