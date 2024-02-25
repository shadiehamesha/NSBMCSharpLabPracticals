//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab4
//{
//    public class Product
//    {
//        private int productId;
//        private string productName;
//        private double price;
//        private int quantityInStock;

//        public Product(int id, string name, double Price, int quantity)
//        {
//            productId = id;
//            productName = name;
//            price = Price;
//            quantityInStock = quantity;
//        }

//        public void AddProduct(int Addquantity)
//        {
//            quantityInStock += Addquantity;
//            Console.WriteLine("Added to stock.");
//        }

//        public void BuyProduct(int Buyquantity)
//        {
//            if (Buyquantity <= quantityInStock)
//            {
//                quantityInStock -= Buyquantity;
//                Console.WriteLine("Product sold.");
//            }
//            else
//            {
//                Console.WriteLine("Not enough products.");
//            }
//        }

//        public void DisplayProductDetails()
//        {
//            Console.WriteLine("Name: " + productName);
//            Console.WriteLine("Price: " + price);
//            Console.WriteLine("Quantity: " + quantityInStock);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Product laptop = new Product(101, "Laptop", 800, 10);
//            laptop.DisplayProductDetails();

//            //laptop.productId = 102;

//            //Comment:
//            //since "productID" is a private property it is not possible to change values. this action results in an error.

//            Console.ReadLine();
//        }
//    }
//}