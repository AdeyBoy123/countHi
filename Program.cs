using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countHi
{
    internal class Program
    {
        static int CountHi(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, Math.Min(2, input.Length - i)) == "hi")
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int count = CountHi(input);

            Console.WriteLine("The number of times hi occurs is: " + count);
            Console.ReadLine();
        }
    }
}
