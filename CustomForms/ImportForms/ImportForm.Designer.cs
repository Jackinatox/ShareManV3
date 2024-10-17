namespace ShareManV3.CustomForms.ImportForms
{
    partial class ImportForm
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
            this.cmb_src = new System.Windows.Forms.ComboBox();
            this.lbl_src = new System.Windows.Forms.Label();
            this.btn_selectPath = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pb_Bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmb_src
            // 
            this.cmb_src.FormattingEnabled = true;
            this.cmb_src.Items.AddRange(new object[] {
            "TeleText"});
            this.cmb_src.Location = new System.Drawing.Point(83, 10);
            this.cmb_src.Name = "cmb_src";
            this.cmb_src.Size = new System.Drawing.Size(204, 21);
            this.cmb_src.TabIndex = 0;
            this.cmb_src.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_src
            // 
            this.lbl_src.AutoSize = true;
            this.lbl_src.Location = new System.Drawing.Point(13, 13);
            this.lbl_src.Name = "lbl_src";
            this.lbl_src.Size = new System.Drawing.Size(64, 13);
            this.lbl_src.TabIndex = 1;
            this.lbl_src.Text = "Datenquelle";
            // 
            // btn_selectPath
            // 
            this.btn_selectPath.Location = new System.Drawing.Point(432, 48);
            this.btn_selectPath.Name = "btn_selectPath";
            this.btn_selectPath.Size = new System.Drawing.Size(24, 20);
            this.btn_selectPath.TabIndex = 2;
            this.btn_selectPath.Text = "...";
            this.btn_selectPath.UseVisualStyleBackColor = true;
            this.btn_selectPath.Click += new System.EventHandler(this.btn_selectPath_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(16, 56);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(29, 13);
            this.lbl_path.TabIndex = 3;
            this.lbl_path.Text = "Pfad";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(83, 48);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(346, 20);
            this.tb_path.TabIndex = 4;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // btn_import
            // 
            this.btn_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_import.Location = new System.Drawing.Point(383, 167);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 5;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(302, 167);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pb_Bar
            // 
            this.pb_Bar.Location = new System.Drawing.Point(19, 167);
            this.pb_Bar.Name = "pb_Bar";
            this.pb_Bar.Size = new System.Drawing.Size(277, 23);
            this.pb_Bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_Bar.TabIndex = 8;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 202);
            this.Controls.Add(this.pb_Bar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_selectPath);
            this.Controls.Add(this.lbl_src);
            this.Controls.Add(this.cmb_src);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_src;
        private System.Windows.Forms.Label lbl_src;
        private System.Windows.Forms.Button btn_selectPath;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ProgressBar pb_Bar;
    }
}