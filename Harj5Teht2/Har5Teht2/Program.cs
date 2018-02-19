using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Har5Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a date:");
            string[] dateStrings = { Console.ReadLine() };
            DateTime dateValue;
            // Console.WriteLine("Attempting to parse strings using {0} culture.", CultureInfo.CurrentCulture.Name);

            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out dateValue))
                    Console.WriteLine("True");
                   // Console.WriteLine("  Converted '{0}' to {1} ({2}).", dateString, dateValue, dateValue.Kind);
                else
                    Console.WriteLine("Invalid date '{0}'.", dateString);
            }
        }
    }
}
