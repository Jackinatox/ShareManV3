namespace ShareManV3.CustomForms
{
    partial class ProgressShower
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
            this.tb_title = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tb_title
            // 
            this.tb_title.AutoSize = true;
            this.tb_title.Location = new System.Drawing.Point(153, 13);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(35, 13);
            this.tb_title.TabIndex = 0;
            this.tb_title.Text = "Name";
            // 
            // tb_description
            // 
            this.tb_description.AutoSize = true;
            this.tb_description.Location = new System.Drawing.Point(12, 92);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(70, 13);
            this.tb_description.TabIndex = 1;
            this.tb_description.Text = "Working on it";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // ProgressShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 132);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_title);
            this.Name = "ProgressShower";
            this.Text = "ProgressShower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tb_title;
        private System.Windows.Forms.Label tb_description;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}