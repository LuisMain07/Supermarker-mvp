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
    public partial class ProductsView : Form, IProductsView
    {

        private bool isEditPR;
        private bool isSuccessfulPR;
        private string messagePR;

        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEventC();

            tabControl1.TabPages.Remove(tabPageProductsDetail);
        }

        private void AssociateAndRaiseViewEventC()
        {
            BtnSearchPR.Click += delegate { SearchEventPR?.Invoke(this, EventArgs.Empty); };

            TxtSearchPR.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEventPR?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string ProductsId
        {
            get { return TxtProductsId.Text; }
            set { TxtProductsId.Text = value; }
        }

        public string ProductsName
        {
            get { return TxtProductsName.Text; }
            set { TxtProductsName.Text = value; }
        }

        public string ProductsPrice
        {
            get { return TxtProductsPrice.Text; }
            set { TxtProductsPrice.Text = value; }
        }

        public string ProductsStock
        {
            get { return TxtProductsStock.Text; }
            set { TxtProductsStock.Text = value; }
        }
        public string ProductsCategoryId
        {
            get { return TxtProductsCategoryId.Text; }
            set { TxtProductsCategoryId.Text = value; }
        }

        public string SearchValuePR
        {
            get { return TxtSearchPR.Text; }
            set { TxtSearchPR.Text = value; }
        }

        public bool IsEditPR
        {
            get { return isEditPR; }
            set { isEditPR = value; }
        }

        public bool IsSuccessfulPR
        {
            get { return isSuccessfulPR; }
            set { isSuccessfulPR = value; }
        }

        public string MessagePR
        {
            get { return messagePR; }
            set { messagePR = value; }
        }

        public event EventHandler SearchEventPR;
        public event EventHandler AddNewEventPR;
        public event EventHandler EditEventPR;
        public event EventHandler DeleteEventPR;
        public event EventHandler SaveEventPR;
        public event EventHandler CancelEventPR;

        public void SetProductsListBildingSource(BindingSource ProductsList)
        {
            DgProducts.DataSource = ProductsList;
        }

        private static ProductsView instancePR;

        public static ProductsView GetInstance(Form parentContainer)
        {
            if (instancePR == null || instancePR.IsDisposed)
            {
                instancePR = new ProductsView();
                instancePR.MdiParent = parentContainer;

                instancePR.FormBorderStyle = FormBorderStyle.None;
                instancePR.Dock = DockStyle.Fill;
            }
            else
            {
                if (instancePR.WindowState == FormWindowState.Minimized)
                {
                    instancePR.WindowState = FormWindowState.Normal;
                }
                instancePR.BringToFront();
            }
            return instancePR;
        }
    }
}
