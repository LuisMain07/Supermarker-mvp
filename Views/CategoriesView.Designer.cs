namespace SupermarkerDefinitive.Views
{
    partial class CategoriesView
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
            tabPageCategoriesList = new TabPage();
            BtnCloseCA = new Button();
            BtnDeleteCA = new Button();
            BtnEditCA = new Button();
            BtnNewCA = new Button();
            DgCategories = new DataGridView();
            BtnSearchCA = new Button();
            TxtSearchCA = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            BtnCancelCA = new Button();
            BtnSaveCA = new Button();
            TxtCategoriesDescription = new TextBox();
            TxtCategoriesName = new TextBox();
            TxtCategoriesId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.bolsa_de_la_compra;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 31);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnCloseCA);
            tabPageCategoriesList.Controls.Add(BtnDeleteCA);
            tabPageCategoriesList.Controls.Add(BtnEditCA);
            tabPageCategoriesList.Controls.Add(BtnNewCA);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnSearchCA);
            tabPageCategoriesList.Controls.Add(TxtSearchCA);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 24);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 322);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseCA
            // 
            BtnCloseCA.BackgroundImage = Properties.Resources.salida1;
            BtnCloseCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCloseCA.Location = new Point(282, 255);
            BtnCloseCA.Name = "BtnCloseCA";
            BtnCloseCA.Size = new Size(64, 59);
            BtnCloseCA.TabIndex = 7;
            BtnCloseCA.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCA
            // 
            BtnDeleteCA.BackgroundImage = Properties.Resources.borrar;
            BtnDeleteCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeleteCA.Location = new Point(282, 201);
            BtnDeleteCA.Name = "BtnDeleteCA";
            BtnDeleteCA.Size = new Size(64, 48);
            BtnDeleteCA.TabIndex = 6;
            BtnDeleteCA.UseVisualStyleBackColor = true;
            // 
            // BtnEditCA
            // 
            BtnEditCA.BackgroundImage = Properties.Resources.firmar;
            BtnEditCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditCA.Location = new Point(282, 142);
            BtnEditCA.Name = "BtnEditCA";
            BtnEditCA.Size = new Size(64, 53);
            BtnEditCA.TabIndex = 5;
            BtnEditCA.UseVisualStyleBackColor = true;
            // 
            // BtnNewCA
            // 
            BtnNewCA.BackgroundImage = Properties.Resources.comercio_electronico;
            BtnNewCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNewCA.Location = new Point(282, 92);
            BtnNewCA.Name = "BtnNewCA";
            BtnNewCA.Size = new Size(64, 44);
            BtnNewCA.TabIndex = 4;
            BtnNewCA.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(8, 91);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.Size = new Size(268, 223);
            DgCategories.TabIndex = 3;
            // 
            // BtnSearchCA
            // 
            BtnSearchCA.BackgroundImage = Properties.Resources.lupa;
            BtnSearchCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchCA.Location = new Point(299, 37);
            BtnSearchCA.Name = "BtnSearchCA";
            BtnSearchCA.Size = new Size(47, 33);
            BtnSearchCA.TabIndex = 2;
            BtnSearchCA.UseVisualStyleBackColor = true;
            // 
            // TxtSearchCA
            // 
            TxtSearchCA.Location = new Point(8, 43);
            TxtSearchCA.Name = "TxtSearchCA";
            TxtSearchCA.PlaceholderText = "Data to search";
            TxtSearchCA.Size = new Size(266, 23);
            TxtSearchCA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 15);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 0;
            label2.Text = "Seach categories";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancelCA);
            tabPageCategoriesDetail.Controls.Add(BtnSaveCA);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesDescription);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Location = new Point(4, 24);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 322);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelCA
            // 
            BtnCancelCA.BackgroundImage = Properties.Resources.borrar1;
            BtnCancelCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelCA.Location = new Point(149, 245);
            BtnCancelCA.Name = "BtnCancelCA";
            BtnCancelCA.Size = new Size(92, 56);
            BtnCancelCA.TabIndex = 7;
            BtnCancelCA.UseVisualStyleBackColor = true;
            // 
            // BtnSaveCA
            // 
            BtnSaveCA.BackgroundImage = Properties.Resources.guardar;
            BtnSaveCA.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSaveCA.Location = new Point(21, 245);
            BtnSaveCA.Name = "BtnSaveCA";
            BtnSaveCA.Size = new Size(92, 56);
            BtnSaveCA.TabIndex = 6;
            BtnSaveCA.UseVisualStyleBackColor = true;
            // 
            // TxtCategoriesDescription
            // 
            TxtCategoriesDescription.Location = new Point(21, 138);
            TxtCategoriesDescription.Multiline = true;
            TxtCategoriesDescription.Name = "TxtCategoriesDescription";
            TxtCategoriesDescription.PlaceholderText = "Search Categories Description";
            TxtCategoriesDescription.Size = new Size(220, 89);
            TxtCategoriesDescription.TabIndex = 5;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(21, 85);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.PlaceholderText = "Search Categories Name";
            TxtCategoriesName.Size = new Size(220, 23);
            TxtCategoriesName.TabIndex = 4;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(21, 32);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.PlaceholderText = "Search Categories Id";
            TxtCategoriesId.Size = new Size(128, 23);
            TxtCategoriesId.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 120);
            label5.Name = "label5";
            label5.Size = new Size(164, 15);
            label5.TabIndex = 2;
            label5.Text = "Search Categories Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 67);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 1;
            label4.Text = "Search Categories Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 14);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 0;
            label3.Text = "Search Categories Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private TextBox TxtSearchCA;
        private Label label2;
        private Button BtnCloseCA;
        private Button BtnDeleteCA;
        private Button BtnEditCA;
        private Button BtnNewCA;
        private DataGridView DgCategories;
        private Button BtnSearchCA;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnCancelCA;
        private Button BtnSaveCA;
        private TextBox TxtCategoriesDescription;
        private TextBox TxtCategoriesName;
        private TextBox TxtCategoriesId;
    }
}