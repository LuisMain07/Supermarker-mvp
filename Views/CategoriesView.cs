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
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEditCA;
        private bool isSuccessfulCA;
        private string messageCA;

        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEventC();

            tabControl1.TabPages.Remove(tabPageCategoriesDetail);
        }

        private void AssociateAndRaiseViewEventC()
        {
            BtnSearchCA.Click += delegate { SearchEventCA?.Invoke(this, EventArgs.Empty); };

            TxtSearchCA.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEventCA?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string CategoriesId
        {
            get { return TxtCategoriesId.Text; }
            set { TxtCategoriesId.Text = value; }
        }

        public string CategoriesName
        {
            get { return TxtCategoriesName.Text; }
            set { TxtCategoriesName.Text = value; }
        }

        public string CategoriesDescription
        {
            get { return TxtCategoriesDescription.Text; }
            set { TxtCategoriesDescription.Text = value; }
        }

        public string SearchValueCA
        {
            get { return TxtSearchCA.Text; }
            set { TxtSearchCA.Text = value; }
        }

        public bool IsEditCA
        {
            get { return isEditCA; }
            set { isEditCA = value; }
        }

        public bool IsSuccessfulCA
        {
            get { return IsSuccessfulCA; }
            set { IsSuccessfulCA = value; }
        }

        public string MessageCA
        {
            get { return messageCA; }
            set { messageCA = value; }
        }

        public event EventHandler SearchEventCA;
        public event EventHandler AddNewEventCA;
        public event EventHandler EditEventCA;
        public event EventHandler DeleteEventCA;
        public event EventHandler SaveEventCA;
        public event EventHandler CancelEventCA;

        public void SetCategoriesListBildingSource(BindingSource CategoriesList)
        {
            DgCategories.DataSource = CategoriesList;
        }
    }
}
