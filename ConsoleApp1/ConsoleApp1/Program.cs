using System;
using System.Diagnostics;
using System.Numerics;

namespace LABBOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Product products = new Product();
            string answer;
            int exitnumber = 0;
            Console.WriteLine("look at out menu " +
                "\n write _product1 to get a banana " +
                "\n write _product2 to get a klubba" +
                "\n write exit to pay for your cart.");
            while (exitnumber != 1)
            {
                Console.WriteLine("Order something more or write exit");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "_product1":

                        Console.WriteLine("this order was added in your cart");

                        customer1._cart.Add(products._product1);
                        break;

                    case "exit":
                        exitnumber = 1;
                        break;
                 default:
                        Console.WriteLine("Enter another name");
                        break;
                }
                string listItems = "";
                foreach (var orderItem in customer1._cart)
                {
                    listItems += orderItem + " , ";

                }
                Console.WriteLine(listItems);
            }
            
        }
    }
}
