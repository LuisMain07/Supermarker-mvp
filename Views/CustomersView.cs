using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarkerDefinitive.Views
{
    public partial class CustomersView : Form, ICustomersViews
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();

            tabControl1.TabPages.Remove(tabPageCustomersDetail);
        }

        private void AssociateAndRaiseViewEvent()
        {
            BtnSearchC.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchC.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string CustomersId
        {
            get { return TxtCustomerId.Text; }
            set { TxtCustomerId.Text = value; }
        }

        public string CustomersDocument_number
        {
            get { return TxtCustomerDN.Text; }
            set { TxtCustomerDN.Text = value; }
        }

        public string CustomersFirst_name
        {
            get { return TxtCustomerFirstName.Text; }
            set { TxtCustomerFirstName.Text = value; }
        }

        public string CustomersLast_name
        {
            get { return TxtCustomerLastName.Text; }
            set { TxtCustomerLastName.Text = value; }
        }

        public string CustomersAddress
        {
            get { return TxtCustomerAddress.Text; }
            set { TxtCustomerAddress.Text = value; }
        }

        public string CustomersBirthday
        {
            get { return TxtCustomerBirthday.Text; }
            set { TxtCustomerBirthday.Text = value; }
        }

        public string CustomersPhone_number
        {
            get { return TxtCustomerPhoneNumber.Text; }
            set { TxtCustomerPhoneNumber.Text = value; }
        }

        public string CustomersEmail
        {
            get { return TxtCustomerEmail.Text; }
            set { TxtCustomerEmail.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearchC.Text; }
            set { TxtSearchC.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource CustomersList)
        {
            DgCustomers.DataSource = CustomersList;
        }

        private static CustomersView instance;

        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void BtnCloseC_Click(object sender, EventArgs e)
        {

        }
    }
}
