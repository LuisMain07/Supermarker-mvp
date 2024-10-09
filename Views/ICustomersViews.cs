using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarkerDefinitive.Views
{
    internal interface ICustomersViews
    {
        string CustomersId { get; set; }
        string CustomersDocument_number { get; set; }
        string CustomersFirst_name { get; set; }
        string CustomersLast_name { get; set; }
        string CustomersAddress { get; set; }
        string CustomersBirthday { get; set; }
        string CustomersPhone_number { get; set; }
        string CustomersEmail { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPayModeListBildingSource(BindingSource CustomersList);
        void Show();
    }
}
