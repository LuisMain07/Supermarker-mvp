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
            CleanViewFieldsPR();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductsId);
            products.Name = view.ProductsName;
            products.Price = view.ProductsPrice;
            products.Stock = view.ProductsStock;
            products.Category_id = view.ProductsCategoryId;

            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEditPR)
                {
                    repository.Edit(products);
                    view.MessagePR = "Product edited successfuly";
                }
                else
                {
                    repository.Add(products);
                    view.MessagePR = "Product added successfuly";
                }
                view.IsSuccessfulPR = true;
                loadAllProductsList();
                CleanViewFieldsPR();
            }
            catch (Exception ex)
            {
                view.IsSuccessfulPR = false;
                view.MessagePR = ex.Message;
            }
        }

        private void CleanViewFieldsPR()
        {
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "";
            view.ProductsStock = "";
            view.ProductsCategoryId = "";
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductsModel)ProductsBindingSource.Current;

                repository.Delete(products.Id);
                view.IsSuccessfulPR = true;
                view.MessagePR = "Product deleted successfully";
                loadAllProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccessfulPR = false;
                view.MessagePR = "An error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var products = (ProductsModel)ProductsBindingSource.Current;

            view.ProductsId = products.Id.ToString();
            view.ProductsName = products.Name;
            view.ProductsPrice = products.Price;
            view.ProductsStock = products.Price;
            view.ProductsCategoryId = products.Category_id;

            view.IsEditPR = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEditPR = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValuePR);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValuePR);
            }
            else
            {
                productsList = repository.GetAll();
            }
            ProductsBindingSource.DataSource = productsList;
        }
    }
}
