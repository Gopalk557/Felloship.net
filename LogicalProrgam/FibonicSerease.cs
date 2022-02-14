using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProrgam
{
    internal class FibonicSerease
    {
        public static void Serease()
        {
            int A = 0;
            int B = 1;
            int C;

            Console.WriteLine(A + "\t" + B);
            for (int i = 3; i <= 10; i++)
            {
                C = A + B;
               

                Console.Write("\t" + C);
                A = B;
                B = C;
            }
        }
    }
}


