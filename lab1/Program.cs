using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            
            Console.WriteLine("Enter the length");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width");
            width = Convert.ToInt32(Console.ReadLine());

            int area = length * width;
            Console.WriteLine("area = " + area);
            Console.ReadLine();


        }
    }
}
