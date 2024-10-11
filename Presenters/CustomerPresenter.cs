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

            this.view.SearchEventC += SearchPayMode;
            this.view.AddNewEventC += AddNewPayMode;
            this.view.EditEventC += LoadSelectPayModeToEdit;
            this.view.DeleteEventC += DeleteSelectedPayMode;
            this.view.SaveEventC += SavePayMode;
            this.view.CancelEventC += CancelAction;

            this.view.SetPayModeListBildingSource(CustomerBindingSource);

            loadAllPayModeList();

            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            customerList = repository.GetAll();
            CustomerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object? sender, EventArgs e)
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
