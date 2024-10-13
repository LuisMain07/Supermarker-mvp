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
    internal class CategoriesRepository : BaseRepositoryCA, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoriesModel categoriesModel)
        {
            using (var connectionC = new SqlConnection(connectionString))
            using (var commandC = new SqlCommand())
            {
                connectionC.Open();
                commandC.Connection = connectionC;
                commandC.CommandText = "INSERT INTO Categories VALUES (@Name, @Description)";
                commandC.Parameters.Add("@Name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                commandC.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoriesModel.Description;

                commandC.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connectionC = new SqlConnection(connectionString))
            using (var commandC = new SqlCommand())
            {
                connectionC.Open();
                commandC.Connection = connectionC;
                commandC.CommandText = "DELETE FROM Categories WHERE Categories_Id = @id";
                commandC.Parameters.Add("@id", SqlDbType.Int).Value = id;
                commandC.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categoriesModel)
        {
            using (var connectionC = new SqlConnection(connectionString))
            using (var commandC = new SqlCommand())
            {
                connectionC.Open();
                commandC.Connection = connectionC;
                commandC.CommandText = @"UPDATE Categories
                                       SET Categories_Name =@Name,
                                       Categories_Description = @Description
                                       WHERE Categories_Id = @Id";
                commandC.Parameters.Add("@Name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                commandC.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoriesModel.Description;

                commandC.Parameters.Add("@Id", SqlDbType.Int).Value = categoriesModel.Id;
                commandC.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoriesList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Categories ORDER BY Categories_Id DESC";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categories_Id"];
                        categoriesModel.Name = reader["Categories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }
            return categoriesList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoriesList = new List<CategoriesModel>();
            int categoriesid = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoriesName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM Categories
                             WHERE Categories_Id=@id or Categories_Name LIKE @name+ '%'
                             ORDER By Categories_Id DESC";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = categoriesid;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesName;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categories_Id"];
                        categoriesModel.Name = reader["Categories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }
            return categoriesList;
        }
    }
}
