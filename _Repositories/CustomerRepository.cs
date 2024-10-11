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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomersModel customersModel)
        {
            throw new NotImplementedException();
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
                        customerModel.Birthday = (DateTime)reader["Customers_Birthday"];
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
                cmd.CommandText = @"SELECT * FROM Customer
                             WHERE Customer_Id=@id or Customer_Document_number LIKE @name+ '%'
                             ORDER Ny Customer_Id DESC";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@Document_number", SqlDbType.NVarChar).Value = customerDocument_number;
                using (var reader = cmd.ExecuteReader())
                {
                    {
                        var customerModel = new CustomersModel();
                        customerModel.Id = (int)reader["Customer_Id"];//customerMode.Birthaday = (DateTime)
                        customerModel.Document_number = reader["Customer_Document_number"].ToString();
                        customerModel.First_name = reader["Customer_First_name"].ToString();
                        customerModel.Last_name = reader["Customer_Last_name"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Customer_Birthday"];
                        customerModel.Phone_number = reader["Customer_Phone_number"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }
    }
}
