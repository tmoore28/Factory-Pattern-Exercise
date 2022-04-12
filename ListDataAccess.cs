using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
            Console.WriteLine("Accessing the list...");
        }
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading your data from your list");
            return Program.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving to your list");
        }
    }
}
