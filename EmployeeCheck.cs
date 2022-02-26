using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagePROBLEM
{
    public class EmployeeCheck
    {

        /// <summary>
        /// Checks the employee presence.
        /// </summary>
        public static void CheckEmployeePresence()
        {
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empCheck = random.Next(2);

            if(empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

    }
}
