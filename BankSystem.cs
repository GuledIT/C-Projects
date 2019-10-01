using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello, what is your name?");
            string firstName = Console.ReadLine();


            Console.WriteLine("What is your surname?");
            string lastName = Console.ReadLine();

            if (firstName.Length > 0 && lastName.Length > 0) {

                NameMethod(firstName, lastName);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a name please");
                Console.ReadLine();
            }
           
        }

        static void NameMethod(string firstName, string lastName)
        {
            Console.WriteLine("Hello, " + firstName +" " + lastName);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What can we do for you today?");
            Console.WriteLine("1: Check account balance " +
                "2:Check invoices");
            Console.ForegroundColor = ConsoleColor.White;

            int menuNumber = Convert.ToInt32(Console.ReadLine());
            if(menuNumber == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your account balance is: 12405020,- NOK");
                Console.ReadLine();
            }
            if (menuNumber == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Last invoice from: TeliaSonera AG, Invoice 423421" +
                    "Sum: 1200,- ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please choose a number");
                Console.ReadLine();
            }
        }
    }
}
