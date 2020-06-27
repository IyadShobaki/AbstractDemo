using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess //IDataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);

            output += " (from SQLite)";

            return output;
        }

        //public string LoadConnectionString(string name)
        //{
        //    Console.WriteLine("Load Connection String");
        //    return "testConnectionString";
        //}
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
