using System;
using System.Collections.Generic;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDatabaseInMemory objnew = new ProductDatabaseInMemory();
            foreach (var item in objnew.GetItems())
            {
                Console.WriteLine("  Direct from product DB " +  item.Id + "  - " + item.Name);
                
            }

            //DTO

            Console.ReadLine();
        }
    }

    class command
    {
        public void Execute<t>()
        {
            //var data = t();
        }
    }

    class productDTO
    {
        public int Id { get; set; }
    }

    /// <summary>
    /// Define a simple product class here with two fields
    /// </summary>
    class product
    {
        public int Id { get; set;}
        public string Name { get; set;}
    }
    class ProductDatabaseInMemory
    {
       readonly List<product> ProductData = new List<product>();
       public List<product> GetItems ()
        {
            ProductData.Add(new product
            {
                Id = 1,
                Name = "a"
            });

            ProductData.Add(new product
            {
                Id = 2,
                Name = "b"
            });

            return ProductData;
        }
    }
}
