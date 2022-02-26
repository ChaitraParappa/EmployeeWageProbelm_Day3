using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagePROBLEM
{
    public class EmpWage
    {
        public static void CalculateEmpWage()
        {
            int IS_FULL_TIME = 1;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;

            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
    }

