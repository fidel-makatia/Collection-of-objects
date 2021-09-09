using System;
using ECommerce;

using System.Collections.Generic;


namespace Collection_of_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> myproducts = new List<Products>();


            string choice;

            do
            {

                Console.WriteLine("Enter product ID");
                int pid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product Name");
                string pname = Console.ReadLine();
                Console.WriteLine("Enter product Price");
                int pprice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product Manufacture Date(yyyy-MM-dd");
                DateTime pdate = DateTime.Parse(Console.ReadLine());


                //create object of class product
                Products product = new Products() { ID = pid, name = pname, price = pprice, DateofManufacture = pdate };

                //add to th list

                myproducts.Add(product);
                Console.WriteLine("products added");
                Console.WriteLine("Do you wish to continue? (Yes/No)");
                choice= Console.ReadLine();

            } while (choice != "No" && choice != "NO" && choice != "no" && choice != "N" && choice != "n");


            //foreach
            Console.WriteLine("\n*******************Products:*****************************");
            foreach(Products item in myproducts)
            {
                Console.WriteLine(item.ID + ". " + item.name + ". " + item.price + "." + item.DateofManufacture.ToShortDateString());
            }
        }
    }
}
