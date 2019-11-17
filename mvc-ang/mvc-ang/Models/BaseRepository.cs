using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using Dapper;

namespace mvc_ang.Models
{
    public class BaseRepository
    {
        public static BaseRepository Model { get; } = new BaseRepository();
        string connectionString = "Data Source=|DataDirectory|\\PurchaseBase.db";

        public List<Product> GetProducts()
        {
            List<Product> users = new List<Product>();
            using (System.Data.IDbConnection db = new SQLiteConnection(connectionString))
            {
                users = db.Query<Product>("SELECT * FROM PRODUCT").ToList();
            }
            return users;
        }

        public List<BuyProduct> GetBuyProducts()
        {
            List<BuyProduct> users = new List<BuyProduct>();
            using (System.Data.IDbConnection db = new SQLiteConnection(connectionString))
            {
                users = db.Query<BuyProduct>("SELECT * FROM BUY_PRODUCT;").ToList();
            }
            foreach (var item in users) { }
            return users;
        }



        //public List<Product> GetUsers()
        //{
        //    List<Product> products = new List<Product>();
        //    using (SQLiteConnection connection = new SQLiteConnection())
        //    {
        //        connection.Open();
        //        string query = "SELECT * from product";
        //        using (SQLiteCommand command = new SQLiteCommand(query, connection))
        //        {
        //            using (SQLiteDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var product = new Product();
        //                    product.id = Convert.ToInt32((Int64)reader["id"]);
        //                    product.title = (string)reader["title"];
        //                    products.Add(product);
        //                }
        //            }
        //        }
        //    }
        //    return products;

        //}

    }
}