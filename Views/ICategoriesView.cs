using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarkerDefinitive.Views
{
    internal interface ICategoriesView
    {
        string CategoriesId { get; set; }
        string CategoriesName { get; set; }
        string CategoriesDescription { get; set; }

        string SearchValueCA { get; set; }
        bool IsEditCA { get; set; }
        bool IsSuccessfulCA { get; set; }
        string MessageCA { get; set; }

        event EventHandler SearchEventCA;
        event EventHandler AddNewEventCA;
        event EventHandler EditEventCA;
        event EventHandler DeleteEventCA;
        event EventHandler SaveEventCA;
        event EventHandler CancelEventCA;

        void SetCategoriesListBildingSource(BindingSource CategoriesList);
        void Show();
    }
}
