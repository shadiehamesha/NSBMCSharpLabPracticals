using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd and Even");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
        }
    }
}
