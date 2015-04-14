using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "one two";
            string result=Regex.Replace(input, @"(\w+)(\s)(\w+)", "${3} ${1}");

            input= @"$16.32 12.19 £16.29 €18.29  €18,29";
            result=Regex.Replace(input, @"\p{Sc}*(\s*\d+[.,]?\d+)\p{Sc}*", " \"$&\" ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
