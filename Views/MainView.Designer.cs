namespace SupermarkerDefinitive.Views
{
    partial class MainView
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
            BtnCategories = new Button();
            BtnCustomers = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.bolsa_de_la_compra;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(-3, 175);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(203, 56);
            BtnCategories.TabIndex = 4;
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = Properties.Resources.segmento_de_clientes;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(-3, 115);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(203, 54);
            BtnCustomers.TabIndex = 3;
            BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 371);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 79);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 56);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(200, 53);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sell1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.agregar;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(-3, 237);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(203, 56);
            BtnProducts.TabIndex = 5;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCustomers;
        private Button BtnCategories;
        private Button BtnProducts;
    }
}