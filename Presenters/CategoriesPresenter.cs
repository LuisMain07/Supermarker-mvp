using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarkerDefinitive.Models;
using SupermarkerDefinitive.Views;

namespace SupermarkerDefinitive.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource CategoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.CategoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEventCA += SearchCategories;
            this.view.AddNewEventCA += AddNewCategories;
            this.view.EditEventCA += LoadSelectCategoriesToEdit;
            this.view.DeleteEventCA += DeleteSelectedCategories;
            this.view.SaveEventCA += SaveCategories;
            this.view.CancelEventCA += CancelActionCA;

            this.view.SetCategoriesListBildingSource(CategoriesBindingSource);

            loadAllCategoriesList();

            this.view.Show();
        }

        private void loadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            CategoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelActionCA(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Description = view.CategoriesDescription;

            try
            {
                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEditCA)
                {
                    repository.Edit(categories);
                    view.MessageCA = "Categories edited successfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.MessageCA = "Categories added successfuly";
                }
                view.IsSuccessfulCA = true;
                loadAllCategoriesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessfulCA = false;
                view.MessageCA = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            try
            {
                var categories = (CategoriesModel)CategoriesBindingSource.Current;

                repository.Delete(categories.Id);
                view.IsSuccessfulCA = true;
                view.MessageCA = "Categories deleted successfully";
                loadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccessfulCA = false;
                view.MessageCA = "An error ocurred, could not delete categories";
            }
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            var categories = (CategoriesModel)CategoriesBindingSource.Current;

            view.CategoriesId = categories.Id.ToString();
            view.CategoriesName = categories.Name.ToString();
            view.CategoriesDescription = categories.Description.ToString();

            view.IsEditCA = true;
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEditCA = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValueCA);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValueCA);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            CategoriesBindingSource.DataSource = categoriesList;
        }
    }
}
