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

        string SearchValueC { get; set; }
        bool IsEditC { get; set; }
        bool IsSuccessfulC { get; set; }
        string MessageC { get; set; }

        event EventHandler SearchEventC;
        event EventHandler AddNewEventC;
        event EventHandler EditEventC;
        event EventHandler DeleteEventC;
        event EventHandler SaveEventC;
        event EventHandler CancelEventC;

        void SetPayModeListBildingSource(BindingSource CustomersList);
        void Show();
    }
}
