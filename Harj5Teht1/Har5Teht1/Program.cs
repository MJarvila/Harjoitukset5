using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har5Teht1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Give a line; I'll check if it's a valid numeric.");
                string input = Console.ReadLine();
                double n;
                bool isNumeric = double.TryParse(input, out n);
                Console.WriteLine(isNumeric);
            }

        }
    }
}
