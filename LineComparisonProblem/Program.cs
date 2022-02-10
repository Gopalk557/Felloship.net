using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to LineComparisonProblem");
            CalculateLineLength line1 = new CalculateLineLength(2, 3, 5, 3);
            line1.CalculateLength();
            CalculateLineLength line2 = new CalculateLineLength(1, 2, 4, 5);
            line2.CalculateLength();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
