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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            tabPageCustomersDetail = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
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
            tabPageCustomersList.Location = new Point(4, 24);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 322);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "CustomersList";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Location = new Point(4, 24);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 322);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "CustomersDetail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
    }
}