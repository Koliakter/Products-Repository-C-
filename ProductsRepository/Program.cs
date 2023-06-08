using ProductsRepository.BusinessLayer;
using ProductsRepository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductsBusiness productsBusiness = new ProductsBusiness(new ProductRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Product> _ProductList = productsBusiness.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("ID   |   Name    |   Price");
                        foreach (Product _product in _ProductList)
                        {
                            Console.WriteLine(_product.ID + "  |   " + _product.Name + "  |   " + _product.Price);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a product:");
                        string id = Console.ReadLine();
                        Product aProduct = productsBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aProduct.ID + ". " + aProduct.Name + " -- " + aProduct.Price);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a product id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Product Type:");
                        string proType = Console.ReadLine();
                        Product aProduct = new Product();
                        aProduct.ID = Convert.ToInt32(id);
                        aProduct.Name = name;
                        aProduct.ProType = proType;
                        bool isExecuted = productsBusiness.Add(aProduct);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a product Type:");
                        string price = Console.ReadLine();
                        Product aProduct = new Product();
                        aProduct.ID = Convert.ToInt32(id);
                        aProduct.Name = name;
                        aProduct.Price = Convert.ToInt32(price);
                        bool isExecuted = productsBusiness.Update(aProduct);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = productsBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
