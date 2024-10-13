using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using SupermarkerDefinitive.Models;
using System.Data;

namespace SupermarkerDefinitive._Repositories
{
    internal class ProductsRepository : BaseRepositoryPR, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Products ORDER BY Products_id DESC";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_name"].ToString();
                        productsModel.Price = reader["Products_price"].ToString();
                        productsModel.Stock = reader["Products_stock"].ToString();
                        productsModel.Category_id = reader["category_id"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsid = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM Products
                             WHERE Products_id=@id or Products_name LIKE @name+ '%'
                             ORDER By Products_id DESC";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = productsid;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_id"];
                        productsModel.Name = reader["Products_name"].ToString();
                        productsModel.Price = reader["Products_Price"].ToString();
                        productsModel.Stock = reader["Products_Stock"].ToString();
                        productsModel.Category_id = reader["category_id"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }
    }
}
