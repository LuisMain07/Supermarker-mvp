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
            throw new NotImplementedException();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
