namespace SupermarkerDefinitive.Views
{
    partial class ProductsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            BtnClosePR = new Button();
            BtnDeletePR = new Button();
            BtnEditPR = new Button();
            BtnNewPR = new Button();
            DgProducts = new DataGridView();
            BtnSearchPR = new Button();
            TxtSearchPR = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            BtnCancelPR = new Button();
            BtnSavePR = new Button();
            TxtProductsCategoryId = new TextBox();
            TxtProductsStock = new TextBox();
            TxtProductsPrice = new TextBox();
            TxtProductsName = new TextBox();
            TxtProductsId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.agregar;
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 34);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnClosePR);
            tabPageProductsList.Controls.Add(BtnDeletePR);
            tabPageProductsList.Controls.Add(BtnEditPR);
            tabPageProductsList.Controls.Add(BtnNewPR);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(BtnSearchPR);
            tabPageProductsList.Controls.Add(TxtSearchPR);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 24);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(792, 322);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnClosePR
            // 
            BtnClosePR.BackgroundImage = Properties.Resources.volver_flecha;
            BtnClosePR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClosePR.Location = new Point(343, 260);
            BtnClosePR.Name = "BtnClosePR";
            BtnClosePR.Size = new Size(75, 54);
            BtnClosePR.TabIndex = 7;
            BtnClosePR.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePR
            // 
            BtnDeletePR.BackgroundImage = Properties.Resources.eliminar;
            BtnDeletePR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeletePR.Location = new Point(343, 198);
            BtnDeletePR.Name = "BtnDeletePR";
            BtnDeletePR.Size = new Size(75, 56);
            BtnDeletePR.TabIndex = 6;
            BtnDeletePR.UseVisualStyleBackColor = true;
            // 
            // BtnEditPR
            // 
            BtnEditPR.BackgroundImage = Properties.Resources.editar_texto;
            BtnEditPR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditPR.Location = new Point(343, 140);
            BtnEditPR.Name = "BtnEditPR";
            BtnEditPR.Size = new Size(75, 52);
            BtnEditPR.TabIndex = 5;
            BtnEditPR.UseVisualStyleBackColor = true;
            // 
            // BtnNewPR
            // 
            BtnNewPR.BackgroundImage = Properties.Resources.agregar_producto1;
            BtnNewPR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNewPR.Location = new Point(343, 86);
            BtnNewPR.Name = "BtnNewPR";
            BtnNewPR.Size = new Size(75, 48);
            BtnNewPR.TabIndex = 4;
            BtnNewPR.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(8, 85);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.Size = new Size(329, 229);
            DgProducts.TabIndex = 3;
            // 
            // BtnSearchPR
            // 
            BtnSearchPR.BackgroundImage = Properties.Resources.buscar1;
            BtnSearchPR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchPR.Location = new Point(355, 30);
            BtnSearchPR.Name = "BtnSearchPR";
            BtnSearchPR.Size = new Size(56, 50);
            BtnSearchPR.TabIndex = 2;
            BtnSearchPR.UseVisualStyleBackColor = true;
            // 
            // TxtSearchPR
            // 
            TxtSearchPR.Location = new Point(8, 45);
            TxtSearchPR.Name = "TxtSearchPR";
            TxtSearchPR.PlaceholderText = "Data to search";
            TxtSearchPR.Size = new Size(329, 23);
            TxtSearchPR.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 27);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Product Id";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(BtnCancelPR);
            tabPageProductsDetail.Controls.Add(BtnSavePR);
            tabPageProductsDetail.Controls.Add(TxtProductsCategoryId);
            tabPageProductsDetail.Controls.Add(TxtProductsStock);
            tabPageProductsDetail.Controls.Add(TxtProductsPrice);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(TxtProductsId);
            tabPageProductsDetail.Controls.Add(label7);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 24);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(792, 322);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelPR
            // 
            BtnCancelPR.BackgroundImage = Properties.Resources.cerrar_simbolo_de_boton_circular;
            BtnCancelPR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelPR.Location = new Point(112, 197);
            BtnCancelPR.Name = "BtnCancelPR";
            BtnCancelPR.Size = new Size(71, 41);
            BtnCancelPR.TabIndex = 12;
            BtnCancelPR.UseVisualStyleBackColor = true;
            // 
            // BtnSavePR
            // 
            BtnSavePR.BackgroundImage = Properties.Resources.disquete;
            BtnSavePR.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSavePR.Location = new Point(8, 197);
            BtnSavePR.Name = "BtnSavePR";
            BtnSavePR.Size = new Size(71, 40);
            BtnSavePR.TabIndex = 10;
            BtnSavePR.UseVisualStyleBackColor = true;
            // 
            // TxtProductsCategoryId
            // 
            TxtProductsCategoryId.Location = new Point(8, 140);
            TxtProductsCategoryId.Name = "TxtProductsCategoryId";
            TxtProductsCategoryId.PlaceholderText = "Search category id";
            TxtProductsCategoryId.Size = new Size(175, 23);
            TxtProductsCategoryId.TabIndex = 9;
            // 
            // TxtProductsStock
            // 
            TxtProductsStock.Location = new Point(242, 85);
            TxtProductsStock.Name = "TxtProductsStock";
            TxtProductsStock.PlaceholderText = "Search stock";
            TxtProductsStock.Size = new Size(175, 23);
            TxtProductsStock.TabIndex = 8;
            // 
            // TxtProductsPrice
            // 
            TxtProductsPrice.Location = new Point(8, 85);
            TxtProductsPrice.Name = "TxtProductsPrice";
            TxtProductsPrice.PlaceholderText = "Search price";
            TxtProductsPrice.Size = new Size(175, 23);
            TxtProductsPrice.TabIndex = 7;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(242, 32);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Search name";
            TxtProductsName.Size = new Size(175, 23);
            TxtProductsName.TabIndex = 6;
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(8, 32);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.PlaceholderText = "Search Id";
            TxtProductsId.Size = new Size(175, 23);
            TxtProductsId.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 122);
            label7.Name = "label7";
            label7.Size = new Size(149, 15);
            label7.TabIndex = 4;
            label7.Text = "Search Product category Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 67);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 3;
            label6.Text = "Search Product stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 67);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 2;
            label5.Text = "Search Product price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 14);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 1;
            label4.Text = "Search Product name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 0;
            label3.Text = "Search Product Id";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Products Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private Label label2;
        private TabPage tabPageProductsDetail;
        private Button BtnSearchPR;
        private TextBox TxtSearchPR;
        private Button BtnClosePR;
        private Button BtnDeletePR;
        private Button BtnEditPR;
        private Button BtnNewPR;
        private DataGridView DgProducts;
        private Button BtnCancelPR;
        private Button BtnSavePR;
        private TextBox TxtProductsCategoryId;
        private TextBox TxtProductsStock;
        private TextBox TxtProductsPrice;
        private TextBox TxtProductsName;
        private TextBox TxtProductsId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}