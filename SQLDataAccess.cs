using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class SQLDataAcess : IDataAccess
    {
        public SQLDataAcess()
        {
            Console.WriteLine("Accessing SQL database...");
        }
        public List<Product> LoadData()
        {
            Console.WriteLine("Im reading data from your SQL database");
            return Program.products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to your SQL data base");
        }
    }
}
