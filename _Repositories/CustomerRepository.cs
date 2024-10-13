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
    internal class CustomerRepository : BaseRepositoryC, ICustomersRepository
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomersModel customersModel)
        {
            using (var connectionC = new SqlConnection(connectionString))
            using (var commandC = new SqlCommand())
            {
                connectionC.Open();
                commandC.Connection = connectionC;
                commandC.CommandText = "INSERT INTO Customers VALUES (@Document_number, @First_name, @Last_name, @Address, @Birthday, @Phone_number, @Email)";
                commandC.Parameters.Add("@Document_number", SqlDbType.NVarChar).Value = customersModel.Document_number;
                commandC.Parameters.Add("@First_name", SqlDbType.NVarChar).Value = customersModel.First_name;
                commandC.Parameters.Add("@Last_name", SqlDbType.NVarChar).Value = customersModel.Last_name;
                commandC.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customersModel.Address;
                commandC.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = customersModel.Birthday;
                commandC.Parameters.Add("@Phone_number", SqlDbType.NVarChar).Value = customersModel.Phone_number;
                commandC.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customersModel.Email;

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
                commandC.CommandText = "DELETE FROM Customers WHERE Customers_Id = @Id";
                commandC.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                commandC.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customersModel)
        {
            using (var connectionC = new SqlConnection(connectionString))
            using (var commandC = new SqlCommand())
            {
                connectionC.Open();
                commandC.Connection = connectionC;
                commandC.CommandText = @"UPDATE Customers 
                                       SET Customers_Document_number =@Document_number,
                                       Customers_First_name = @First_name,
                                       Customers_Last_name = @Last_name,
                                       Customers_Address = @Address,
                                       Customers_Birthday = @Birthday,
                                       Customers_Phone_number = @Phone_number,
                                       Customers_Email = @Email
                                       WHERE Customers_Id = @Id";
                commandC.Parameters.Add("@Document_number", SqlDbType.NVarChar).Value = customersModel.Document_number;
                commandC.Parameters.Add("@First_name", SqlDbType.NVarChar).Value = customersModel.First_name;
                commandC.Parameters.Add("@Last_name", SqlDbType.NVarChar).Value = customersModel.Last_name;
                commandC.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customersModel.Address;
                commandC.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = customersModel.Birthday;
                commandC.Parameters.Add("@Phone_number", SqlDbType.NVarChar).Value = customersModel.Phone_number;
                commandC.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customersModel.Email;

                commandC.Parameters.Add("@id", SqlDbType.Int).Value = customersModel.Id;
                commandC.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customerList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document_number = reader["Customers_Document_number"].ToString();
                        customersModel.First_name = reader["Customers_First_name"].ToString();
                        customersModel.Last_name = reader["Customers_Last_name"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["Customers_Birthday"].ToString();
                        customersModel.Phone_number = reader["Customers_Phone_number"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customerList.Add(customersModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customersid = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM Customers
                             WHERE Customers_Id=@id or Customers_Document_number LIKE @document_number+ '%'
                             ORDER By Customers_Id DESC";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = customersid;
                cmd.Parameters.Add("@document_number", SqlDbType.NVarChar).Value = customersName;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document_number = reader["Customers_Document_number"].ToString();
                        customersModel.First_name = reader["Customers_First_name"].ToString();
                        customersModel.Last_name = reader["Customers_Last_name"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["Customers_Birthday"].ToString();
                        customersModel.Phone_number = reader["Customers_Phone_number"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }
    }
}
