using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class CalculateLineLength
    {
        int x1, y1, x2, y2;
        public CalculateLineLength(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void CalculateLength()
        {
            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(Length);
        

            int x1, y1, x2, y2;
            public CalculateLineLength(int x1, int y1, int x2, int y2)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }
            public void CalculateLength()
            {
                double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                // Console.WriteLine(Length);


            }
        }

    }
}
