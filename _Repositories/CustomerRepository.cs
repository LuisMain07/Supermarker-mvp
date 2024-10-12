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
            var Customerlist = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomersModel();
                        customerModel.Id = (int)reader["Customers_Id"];
                        customerModel.Document_number = reader["Customers_Document_number"].ToString();
                        customerModel.First_name = reader["Customers_First_Name"].ToString();
                        customerModel.Last_name = reader["Customers_Last_Name"].ToString();
                        customerModel.Address = reader["Customers_Address"].ToString();
                        customerModel.Birthday = reader["Customers_Birthday"].ToString();
                        customerModel.Phone_number = reader["Customers_Phone_number"].ToString();
                        customerModel.Email = reader["Customers_Email"].ToString();
                        Customerlist.Add(customerModel);
                    }
                }
            }
            return Customerlist;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customerList = new List<CustomersModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerDocument_number = value;
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM Customers
                             WHERE Customers_Id=@Id or Customers_Document_number LIKE @Id+ '%'
                             ORDER By Customers_Id DESC";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@Document_number", SqlDbType.NVarChar).Value = customerDocument_number;
                using (var reader = cmd.ExecuteReader())
                {
                    {
                        var customerModel = new CustomersModel();
                        customerModel.Id = (int)reader["Customers_Id"];
                        customerModel.Document_number = reader["Customers_Document_number"].ToString();
                        customerModel.First_name = reader["Customers_First_name"].ToString();
                        customerModel.Last_name = reader["Customers_Last_name"].ToString();
                        customerModel.Address = reader["Customers_Address"].ToString();
                        customerModel.Birthday = reader["Customers_Birthday"].ToString();
                        customerModel.Phone_number = reader["Customers_Phone_number"].ToString();
                        customerModel.Email = reader["Customers_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }
    }
}
