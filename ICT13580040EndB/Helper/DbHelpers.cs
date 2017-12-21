using System;
using ICT13580040EndB.Models;
using SQLite;

namespace ICT13580040EndB.Helper
{
    public class DbHelpers
    {
        private string dbPath;

        public DbHelpers(string dbPath)
        {
            this.dbPath = dbPath;
        }

        public class DbHelper
        {
            SQLiteConnection db;
            public DbHelper(string dbPath)
            {
                db = new SQLiteConnection(dbPath);
                db.CreateTable<Product>();
            }
            public int AddProduct(Product product)
            {
                db.Insert(product);
                return product.Id;
            }

        }
    }
}
