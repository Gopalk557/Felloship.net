using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOperation
{
    internal class EmployeeWage
    {
        public static void EmployeeAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
        }
    }
}
