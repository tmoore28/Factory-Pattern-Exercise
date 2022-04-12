using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
            Console.WriteLine("Accessing Mongo...");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from your mongo database");
            return Program.products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to your Mongo database");

        }
    }
}
