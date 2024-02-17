using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static double accBalance = 10000;

        static void Checkbalance()
        {
            Console.WriteLine("Your current balance is: "+accBalance);
        }

        static void Depositmoney()
        {
            Console.WriteLine("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            accBalance += amount;
            Console.WriteLine("Successful ! Your balance is: "+accBalance);
        }

        static void Withdrawmoney()
        {
            Console.WriteLine("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > accBalance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                accBalance -= amount;
                Console.WriteLine("Successful ! Your balance is: "+accBalance);
            }
        }
        static void Main(string[] args)
        {
            bool program = true;

            while (program)
            {
                Console.WriteLine("Welcome !");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Checkbalance();
                        break;
                    case 2:
                        Depositmoney();
                        break;
                    case 3:
                        Withdrawmoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you");
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
