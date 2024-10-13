using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarkerDefinitive.Models;
using SupermarkerDefinitive.Views;

namespace SupermarkerDefinitive.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource ProductsBindingSource;
        private IEnumerable<ProductsModel> productsList;
        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.ProductsBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEventPR += SearchProducts;
            this.view.AddNewEventPR += AddNewProducts;
            this.view.EditEventPR += LoadSelectProductsToEdit;
            this.view.DeleteEventPR += DeleteSelectedProducts;
            this.view.SaveEventPR += SaveProducts;
            this.view.CancelEventPR += CancelActionPR;

            this.view.SetProductsListBildingSource(ProductsBindingSource);

            loadAllProductsList();

            this.view.Show();
        }

        private void loadAllProductsList()
        {
            productsList = repository.GetAll();
            ProductsBindingSource.DataSource = productsList;
        }

        private void CancelActionPR(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
