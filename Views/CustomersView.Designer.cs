namespace SupermarkerDefinitive.Views
{
    partial class CustomersView
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
            tabPageCustomersList = new TabPage();
            BtnCloseC = new Button();
            BtnDeleteC = new Button();
            BtnEditC = new Button();
            BtnNewC = new Button();
            DgCustomers = new DataGridView();
            BtnSearchC = new Button();
            TxtSearchC = new TextBox();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            BtnCancelC = new Button();
            BtnSaveC = new Button();
            TxtCustomerEmail = new TextBox();
            label10 = new Label();
            TxtCustomerPhoneNumber = new TextBox();
            label9 = new Label();
            TxtCustomerBirthday = new TextBox();
            label8 = new Label();
            TxtCustomerAddress = new TextBox();
            label7 = new Label();
            TxtCustomerLastName = new TextBox();
            label6 = new Label();
            TxtCustomerFirstName = new TextBox();
            label5 = new Label();
            TxtCustomerDN = new TextBox();
            label4 = new Label();
            TxtCustomerId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.clientes;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 30);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnCloseC);
            tabPageCustomersList.Controls.Add(BtnDeleteC);
            tabPageCustomersList.Controls.Add(BtnEditC);
            tabPageCustomersList.Controls.Add(BtnNewC);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(BtnSearchC);
            tabPageCustomersList.Controls.Add(TxtSearchC);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 24);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 322);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "CustomersList";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseC
            // 
            BtnCloseC.BackgroundImage = Properties.Resources.cerrar_sesion;
            BtnCloseC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCloseC.Location = new Point(428, 278);
            BtnCloseC.Name = "BtnCloseC";
            BtnCloseC.Size = new Size(65, 36);
            BtnCloseC.TabIndex = 7;
            BtnCloseC.UseVisualStyleBackColor = true;
            BtnCloseC.Click += BtnCloseC_Click;
            // 
            // BtnDeleteC
            // 
            BtnDeleteC.BackgroundImage = Properties.Resources.basura;
            BtnDeleteC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeleteC.Location = new Point(428, 213);
            BtnDeleteC.Name = "BtnDeleteC";
            BtnDeleteC.Size = new Size(65, 45);
            BtnDeleteC.TabIndex = 6;
            BtnDeleteC.UseVisualStyleBackColor = true;
            // 
            // BtnEditC
            // 
            BtnEditC.BackgroundImage = Properties.Resources.nota;
            BtnEditC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditC.Location = new Point(428, 149);
            BtnEditC.Name = "BtnEditC";
            BtnEditC.Size = new Size(65, 45);
            BtnEditC.TabIndex = 5;
            BtnEditC.UseVisualStyleBackColor = true;
            // 
            // BtnNewC
            // 
            BtnNewC.BackgroundImage = Properties.Resources.agregar_producto;
            BtnNewC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNewC.Location = new Point(428, 89);
            BtnNewC.Name = "BtnNewC";
            BtnNewC.Size = new Size(65, 45);
            BtnNewC.TabIndex = 4;
            BtnNewC.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(8, 89);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.Size = new Size(392, 225);
            DgCustomers.TabIndex = 3;
            // 
            // BtnSearchC
            // 
            BtnSearchC.BackgroundImage = Properties.Resources.buscar;
            BtnSearchC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchC.Location = new Point(260, 47);
            BtnSearchC.Name = "BtnSearchC";
            BtnSearchC.Size = new Size(47, 31);
            BtnSearchC.TabIndex = 2;
            BtnSearchC.UseVisualStyleBackColor = true;
            // 
            // TxtSearchC
            // 
            TxtSearchC.Location = new Point(8, 52);
            TxtSearchC.Name = "TxtSearchC";
            TxtSearchC.PlaceholderText = "Data to search";
            TxtSearchC.Size = new Size(235, 23);
            TxtSearchC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 34);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Customers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(BtnCancelC);
            tabPageCustomersDetail.Controls.Add(BtnSaveC);
            tabPageCustomersDetail.Controls.Add(TxtCustomerEmail);
            tabPageCustomersDetail.Controls.Add(label10);
            tabPageCustomersDetail.Controls.Add(TxtCustomerPhoneNumber);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(TxtCustomerBirthday);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(TxtCustomerAddress);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(TxtCustomerLastName);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(TxtCustomerFirstName);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(TxtCustomerDN);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(TxtCustomerId);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 24);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 322);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "CustomersDetail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelC
            // 
            BtnCancelC.BackgroundImage = Properties.Resources.boton_x;
            BtnCancelC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelC.Location = new Point(351, 208);
            BtnCancelC.Name = "BtnCancelC";
            BtnCancelC.Size = new Size(50, 43);
            BtnCancelC.TabIndex = 17;
            BtnCancelC.UseVisualStyleBackColor = true;
            // 
            // BtnSaveC
            // 
            BtnSaveC.BackgroundImage = Properties.Resources.archivo;
            BtnSaveC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSaveC.Location = new Point(267, 208);
            BtnSaveC.Name = "BtnSaveC";
            BtnSaveC.Size = new Size(55, 43);
            BtnSaveC.TabIndex = 16;
            BtnSaveC.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(255, 140);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.PlaceholderText = "Email";
            TxtCustomerEmail.Size = new Size(156, 23);
            TxtCustomerEmail.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(255, 122);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 14;
            label10.Text = "Customers Email";
            // 
            // TxtCustomerPhoneNumber
            // 
            TxtCustomerPhoneNumber.Location = new Point(255, 87);
            TxtCustomerPhoneNumber.Name = "TxtCustomerPhoneNumber";
            TxtCustomerPhoneNumber.PlaceholderText = "Phone number";
            TxtCustomerPhoneNumber.Size = new Size(156, 23);
            TxtCustomerPhoneNumber.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 69);
            label9.Name = "label9";
            label9.Size = new Size(146, 15);
            label9.TabIndex = 12;
            label9.Text = "Customers Phone number";
            // 
            // TxtCustomerBirthday
            // 
            TxtCustomerBirthday.Location = new Point(255, 30);
            TxtCustomerBirthday.Name = "TxtCustomerBirthday";
            TxtCustomerBirthday.PlaceholderText = "yyyy-mm-dd";
            TxtCustomerBirthday.Size = new Size(156, 23);
            TxtCustomerBirthday.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 12);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 10;
            label8.Text = "Customers Birthday";
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(23, 261);
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.PlaceholderText = "Address";
            TxtCustomerAddress.Size = new Size(156, 23);
            TxtCustomerAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 243);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 8;
            label7.Text = "Customers Address";
            // 
            // TxtCustomerLastName
            // 
            TxtCustomerLastName.Location = new Point(23, 201);
            TxtCustomerLastName.Name = "TxtCustomerLastName";
            TxtCustomerLastName.PlaceholderText = "Last name";
            TxtCustomerLastName.Size = new Size(156, 23);
            TxtCustomerLastName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 183);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 6;
            label6.Text = "Customers Last name";
            // 
            // TxtCustomerFirstName
            // 
            TxtCustomerFirstName.Location = new Point(23, 140);
            TxtCustomerFirstName.Name = "TxtCustomerFirstName";
            TxtCustomerFirstName.PlaceholderText = "First Name";
            TxtCustomerFirstName.Size = new Size(156, 23);
            TxtCustomerFirstName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 122);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 4;
            label5.Text = "Customers First name";
            // 
            // TxtCustomerDN
            // 
            TxtCustomerDN.Location = new Point(23, 87);
            TxtCustomerDN.Name = "TxtCustomerDN";
            TxtCustomerDN.PlaceholderText = "Document Number";
            TxtCustomerDN.Size = new Size(156, 23);
            TxtCustomerDN.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 69);
            label4.Name = "label4";
            label4.Size = new Size(170, 15);
            label4.TabIndex = 2;
            label4.Text = "Customers Document Number";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(23, 30);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.Size = new Size(156, 23);
            TxtCustomerId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 12);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Customers id";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private Button BtnSearchC;
        private TextBox TxtSearchC;
        private Label label2;
        private Button BtnCloseC;
        private Button BtnDeleteC;
        private Button BtnEditC;
        private Button BtnNewC;
        private DataGridView DgCustomers;
        private Label label4;
        private TextBox TxtCustomerId;
        private Label label3;
        private Label label5;
        private TextBox TxtCustomerDN;
        private Label label6;
        private TextBox TxtCustomerFirstName;
        private Label label7;
        private TextBox TxtCustomerLastName;
        private TextBox TxtCustomerAddress;
        private Label label8;
        private TextBox TxtCustomerBirthday;
        private TextBox TxtCustomerPhoneNumber;
        private Label label9;
        private TextBox TxtCustomerEmail;
        private Label label10;
        private Button BtnCancelC;
        private Button BtnSaveC;
    }
}