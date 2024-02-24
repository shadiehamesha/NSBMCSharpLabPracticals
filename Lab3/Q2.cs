//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3
//{
//    class BankAccount
//    {
//        public int AccountNumber { get; set; }
//        public int Balance { get; set; }

//        public void Deposit(int amount)
//        {
//            Balance += amount;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount baccount = new BankAccount();
//            baccount.AccountNumber = 100;
//            baccount.Balance = 5000;

//            Console.WriteLine("Enter the amount: ");
//            int value = Convert.ToInt32(Console.ReadLine());
//            baccount.Deposit(value);

//            Console.WriteLine("Balance: " + baccount.Balance);
//            Console.ReadLine();
//        }
//    }
//}
