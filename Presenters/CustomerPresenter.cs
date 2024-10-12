using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarkerDefinitive.Views;
using SupermarkerDefinitive.Models;

namespace SupermarkerDefinitive.Presenters
{
    class CustomerPresenter
    {
        private ICustomersViews view;
        private ICustomersRepository repository;
        private BindingSource CustomerBindingSource;
        private IEnumerable<CustomersModel> customerList;

        public CustomerPresenter(ICustomersViews view, ICustomersRepository repository)
        {
            this.CustomerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEventC += SearchCustomer;
            this.view.AddNewEventC += AddNewCustomer;
            this.view.EditEventC += LoadSelectCustomerToEdit;
            this.view.DeleteEventC += DeleteSelectedCustomer;
            this.view.SaveEventC += SaveCustomer;
            this.view.CancelEventC += CancelAction;

            this.view.SetCustomerListBildingSource(CustomerBindingSource);

            loadAllCustomerList();

            this.view.Show();
        }

        private void loadAllCustomerList()
        {
            customerList = repository.GetAll();
            CustomerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomersModel();
            customer.Id = Convert.ToInt32(view.CustomersId);
            customer.Document_number = view.CustomersDocument_number;
            customer.First_name = view.CustomersFirst_name;
            customer.Last_name = view.CustomersLast_name;
            customer.Address = view.CustomersAddress;
            customer.Birthday = view.CustomersBirthday;
            customer.Phone_number = view.CustomersPhone_number;
            customer.Email = view.CustomersEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customer);
                if (view.IsEditC)
                {
                    repository.Edit(customer);
                    view.MessageC = "Customer edited successfuly";
                }
                else
                {
                    repository.Add(customer);
                    view.MessageC = "Customer added successfuly";   
                }
                view.IsSuccessfulC = true;
                loadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessfulC = false;
                view.MessageC = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersDocument_number = "";
            view.CustomersFirst_name = "";
            view.CustomersLast_name = "";
            view.CustomersAddress = "";
            view.CustomersBirthday = "";
            view.CustomersPhone_number = "";
            view.CustomersEmail = "";
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomersModel)CustomerBindingSource.Current;

                repository.Delete(customer.Id);
                view.IsSuccessfulC = true;
                view.MessageC = "Customer deleted successfully";
                loadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessfulC = false;
                view.MessageC = "An error ocurred, could not delete customer";
            }
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomersModel)CustomerBindingSource.Current;

            view.CustomersId = customer.Id.ToString();
            view.CustomersDocument_number = customer.Document_number.ToString();
            view.CustomersFirst_name = customer.First_name.ToString();
            view.CustomersLast_name = customer.Last_name.ToString();
            view.CustomersAddress = customer.Address.ToString();
            view.CustomersBirthday = customer.Birthday.ToString();
            view.CustomersPhone_number = customer.Phone_number.ToString();
            view.CustomersEmail = customer.Email.ToString();

            view.IsEditC = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEditC = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValueC);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValueC);
            }
            else
            {
                customerList = repository.GetAll();
            }
            CustomerBindingSource.DataSource = customerList;
        }
    }
}
