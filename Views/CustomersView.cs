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
        private bool isEditC;
        private bool isSuccessfulC;
        private string messageC;

        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEventC();

            tabControl1.TabPages.Remove(tabPageCustomersDetail);

            BtnCloseC.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEventC()
        {
            BtnSearchC.Click += delegate { SearchEventC?.Invoke(this, EventArgs.Empty); };

            TxtSearchC.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEventC?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNewC.Click += delegate {
                AddNewEventC?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Add new pay mode";
            };

            BtnEditC.Click += delegate {
                EditEventC?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Edit pay mode";
            };

            BtnDeleteC.Click += delegate {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    DeleteEventC?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(MessageC);
                }

            };

            BtnSaveC.Click += delegate {
                SaveEventC?.Invoke(this, EventArgs.Empty);

                if (isSuccessfulC)
                {
                    tabControl1.TabPages.Remove(tabPageCustomersDetail);
                    tabControl1.TabPages.Add(tabPageCustomersList);
                }
                MessageBox.Show(messageC);
            };

            BtnCancelC.Click += delegate {
                CancelEventC?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersDetail);
                tabControl1.TabPages.Add(tabPageCustomersList);
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

        public string SearchValueC
        {
            get { return TxtSearchC.Text; }
            set { TxtSearchC.Text = value; }
        }

        public bool IsEditC
        {
            get { return isEditC; }
            set { isEditC = value; }
        }

        public bool IsSuccessfulC
        {
            get { return isSuccessfulC; }
            set { isSuccessfulC = value; }
        }

        public string MessageC
        {
            get { return messageC; }
            set { messageC = value; }
        }

        public event EventHandler SearchEventC;
        public event EventHandler AddNewEventC;
        public event EventHandler EditEventC;
        public event EventHandler DeleteEventC;
        public event EventHandler SaveEventC;
        public event EventHandler CancelEventC;

        public void SetCustomerListBildingSource(BindingSource CustomersList)
        {
            DgCustomers.DataSource = CustomersList;
        }

        private static CustomersView instanceC;

        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instanceC == null || instanceC.IsDisposed)
            {
                instanceC = new CustomersView();
                instanceC.MdiParent = parentContainer;

                instanceC.FormBorderStyle = FormBorderStyle.None;
                instanceC.Dock = DockStyle.Fill;
            }
            else
            {
                if (instanceC.WindowState == FormWindowState.Minimized)
                {
                    instanceC.WindowState = FormWindowState.Normal;
                }
                instanceC.BringToFront();
            }
            return instanceC;
        }

        private void BtnCloseC_Click(object sender, EventArgs e)
        {

        }
    }
}
