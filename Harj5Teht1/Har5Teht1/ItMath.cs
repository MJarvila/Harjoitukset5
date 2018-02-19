using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har5Teht1
{
    public class ItMath
    {
        private string input;
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        private static bool isNumeric;
        public static bool IsNumeric(string Input)
        {
            double n;
            bool isNumeric = double.TryParse(Input, out n);
            Console.WriteLine(isNumeric);
            return isNumeric;
        }

    }
}
