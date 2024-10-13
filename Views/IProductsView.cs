using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarkerDefinitive.Views
{
    internal interface IProductsView
    {
        string ProductsId { get; set; }
        string ProductsName { get; set; }
        string ProductsPrice { get; set; }
        string ProductsStock { get; set; }
        string ProductsCategoryId { get; set; }

        string SearchValuePR { get; set; }
        bool IsEditPR { get; set; }
        bool IsSuccessfulPR { get; set; }
        string MessagePR { get; set; }

        event EventHandler SearchEventPR;
        event EventHandler AddNewEventPR;
        event EventHandler EditEventPR;
        event EventHandler DeleteEventPR;
        event EventHandler SaveEventPR;
        event EventHandler CancelEventPR;

        void SetProductsListBildingSource(BindingSource ProductsList);
        void Show();
    }
}
