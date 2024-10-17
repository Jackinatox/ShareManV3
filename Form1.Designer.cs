namespace ShareManV3
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Suche = new System.Windows.Forms.TabPage();
            this.Depot = new System.Windows.Forms.TabPage();
            this.stockList1 = new ShareManV3.StockList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Suche);
            this.tabControl1.Controls.Add(this.Depot);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 407);
            this.tabControl1.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.button1);
            this.Home.Controls.Add(this.stockList1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(798, 381);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Suche
            // 
            this.Suche.Location = new System.Drawing.Point(4, 22);
            this.Suche.Name = "Suche";
            this.Suche.Padding = new System.Windows.Forms.Padding(3);
            this.Suche.Size = new System.Drawing.Size(870, 346);
            this.Suche.TabIndex = 1;
            this.Suche.Text = "Suche";
            this.Suche.UseVisualStyleBackColor = true;
            // 
            // Depot
            // 
            this.Depot.Location = new System.Drawing.Point(4, 22);
            this.Depot.Name = "Depot";
            this.Depot.Size = new System.Drawing.Size(798, 381);
            this.Depot.TabIndex = 2;
            this.Depot.Text = "Depot";
            this.Depot.UseVisualStyleBackColor = true;
            // 
            // stockList1
            // 
            this.stockList1.dbh = null;
            this.stockList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockList1.Location = new System.Drawing.Point(3, 3);
            this.stockList1.Name = "stockList1";
            this.stockList1.Size = new System.Drawing.Size(792, 375);
            this.stockList1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 30);
            this.panel1.TabIndex = 3;
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.Location = new System.Drawing.Point(719, 4);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(82, 23);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Einstellungen";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Button button1;
        private StockList stockList1;
        private System.Windows.Forms.TabPage Suche;
        private System.Windows.Forms.TabPage Depot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_settings;
    }
}

