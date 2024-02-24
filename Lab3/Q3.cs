//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3
//{
//    class TemparatureTracker
//    {
//        private int[] temperaturearr = {0,0,0,0,0,0,0};

//        public void SaveTemperature(int val, int temp)
//        {
//            temperaturearr[val] = temp;
//        }

//        public void DisplayTemp()
//        {
//            Console.WriteLine("Temperature Values: ");
//            for (int i = 0; i < temperaturearr.Length; i++)
//            {
//                Console.WriteLine(" " + temperaturearr[i]);
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TemparatureTracker temptracker = new TemparatureTracker();

//            for (int i = 0; i < 7; i++)
//            {
//                Console.Write("Enter temperature: ");
//                int value = Convert.ToInt32(Console.ReadLine());
//                temptracker.SaveTemperature(i, value);
//            }

//            temptracker.DisplayTemp();
//            Console.ReadLine();
//        }
//    }
//}
