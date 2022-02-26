using System;

/// <summary>
/// 
/// </summary>
namespace EmployeeWagePROBLEM
{
    /// <summary>
    /// Containes the main method
    /// </summary>
    class Program
    {
        /// <summary>
        /// Displaying the Greeting Message.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            //Display the message
            Console.WriteLine("Welcome to Employee Wage Program");

            EmployeeCheck.CheckEmployeePresence();
        }
    }
}
