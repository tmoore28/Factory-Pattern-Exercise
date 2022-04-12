using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                case "mysql":
                    return new SQLDataAcess();
                case "mongo":
                case "mongodb":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();


            }
        }
    }
}
