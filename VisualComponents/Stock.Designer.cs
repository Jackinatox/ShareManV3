namespace ShareManV3
{
    partial class Stock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblName.MaximumSize = new System.Drawing.Size(0, 45);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(118, 45);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMonth, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeek, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblToday, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 45);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Location = new System.Drawing.Point(546, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(56, 45);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Monthly";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeek
            // 
            this.lblWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeek.Location = new System.Drawing.Point(486, 0);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(54, 45);
            this.lblWeek.TabIndex = 2;
            this.lblWeek.Text = "Weekly";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToday
            // 
            this.lblToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToday.Location = new System.Drawing.Point(426, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(54, 45);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Daily";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(605, 45);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblToday;
    }
}
