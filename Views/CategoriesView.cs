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

            BtnCloseCA.Click += delegate { this.Close(); };
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

            BtnNewCA.Click += delegate {
                AddNewEventCA?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Add new categories";
            };

            BtnEditCA.Click += delegate {
                EditEventCA?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Edit categories";
            };

            BtnDeleteCA.Click += delegate {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected categories",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    DeleteEventCA?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(MessageCA);
                }

            };

            BtnSaveCA.Click += delegate {
                SaveEventCA?.Invoke(this, EventArgs.Empty);

                if (isSuccessfulCA)
                {
                    tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                    tabControl1.TabPages.Add(tabPageCategoriesList);
                }
                MessageBox.Show(messageCA);
            };

            BtnCancelCA.Click += delegate {
                CancelEventCA?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                tabControl1.TabPages.Add(tabPageCategoriesList);
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
            get { return isSuccessfulCA; }
            set { isSuccessfulCA = value; }
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

        private static CategoriesView instanceCA;

        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instanceCA == null || instanceCA.IsDisposed)
            {
                instanceCA = new CategoriesView();
                instanceCA.MdiParent = parentContainer;

                instanceCA.FormBorderStyle = FormBorderStyle.None;
                instanceCA.Dock = DockStyle.Fill;
            }
            else
            {
                if (instanceCA.WindowState == FormWindowState.Minimized)
                {
                    instanceCA.WindowState = FormWindowState.Normal;
                }
                instanceCA.BringToFront();
            }
            return instanceCA;
        }
    }
}
