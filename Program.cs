using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    class Program
    {
        public static List<Product> products = new List<Product>()
        {
            new Product() {Name = "Hover Board", Price = 289.99},
            new Product() {Name = "Skate Board", Price = 489.99},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? \nList , SQL, Mongo?");

            var response = Console.ReadLine();

            IDataAccess da = DataAccessFactory.GetDataAccessType(response);

            var productsReturned = da.LoadData();

            Console.WriteLine("Here are your items:\n");

            foreach (var item in productsReturned)
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Price: {item.Price}");
            }
        }
    }
}
