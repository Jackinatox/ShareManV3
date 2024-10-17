namespace ShareManV3
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_Folder = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_apiKey = new System.Windows.Forms.TextBox();
            this.lbl_alphavantage_Key = new System.Windows.Forms.Label();
            this.tb_alphavantage_Key = new System.Windows.Forms.TextBox();
            this.tb_mxSearches = new System.Windows.Forms.NumericUpDown();
            this.lbl_maxSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_mxSearches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speicherort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theme";
            // 
            // cb_theme
            // 
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(142, 31);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(213, 21);
            this.cb_theme.TabIndex = 2;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(142, 88);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(182, 20);
            this.tb_path.TabIndex = 3;
            // 
            // btn_Folder
            // 
            this.btn_Folder.Location = new System.Drawing.Point(330, 86);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(25, 23);
            this.btn_Folder.TabIndex = 4;
            this.btn_Folder.Text = "...";
            this.btn_Folder.UseVisualStyleBackColor = true;
            this.btn_Folder.Click += new System.EventHandler(this.btn_Folder_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(199, 225);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(116, 225);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(280, 225);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 7;
            this.button_apply.Text = "Anwenden";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TwelveData Key";
            // 
            // tb_apiKey
            // 
            this.tb_apiKey.Location = new System.Drawing.Point(142, 60);
            this.tb_apiKey.Name = "tb_apiKey";
            this.tb_apiKey.Size = new System.Drawing.Size(213, 20);
            this.tb_apiKey.TabIndex = 9;
            // 
            // lbl_alphavantage_Key
            // 
            this.lbl_alphavantage_Key.AutoSize = true;
            this.lbl_alphavantage_Key.Location = new System.Drawing.Point(25, 126);
            this.lbl_alphavantage_Key.Name = "lbl_alphavantage_Key";
            this.lbl_alphavantage_Key.Size = new System.Drawing.Size(94, 13);
            this.lbl_alphavantage_Key.TabIndex = 11;
            this.lbl_alphavantage_Key.Text = "Alphavantage Key";
            // 
            // tb_alphavantage_Key
            // 
            this.tb_alphavantage_Key.Location = new System.Drawing.Point(142, 123);
            this.tb_alphavantage_Key.Name = "tb_alphavantage_Key";
            this.tb_alphavantage_Key.Size = new System.Drawing.Size(213, 20);
            this.tb_alphavantage_Key.TabIndex = 12;
            // 
            // tb_mxSearches
            // 
            this.tb_mxSearches.Location = new System.Drawing.Point(142, 161);
            this.tb_mxSearches.Name = "tb_mxSearches";
            this.tb_mxSearches.Size = new System.Drawing.Size(213, 20);
            this.tb_mxSearches.TabIndex = 13;
            // 
            // lbl_maxSearch
            // 
            this.lbl_maxSearch.AutoSize = true;
            this.lbl_maxSearch.Location = new System.Drawing.Point(25, 163);
            this.lbl_maxSearch.Name = "lbl_maxSearch";
            this.lbl_maxSearch.Size = new System.Drawing.Size(64, 13);
            this.lbl_maxSearch.TabIndex = 14;
            this.lbl_maxSearch.Text = "Max Search";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 260);
            this.Controls.Add(this.lbl_maxSearch);
            this.Controls.Add(this.tb_mxSearches);
            this.Controls.Add(this.tb_alphavantage_Key);
            this.Controls.Add(this.lbl_alphavantage_Key);
            this.Controls.Add(this.tb_apiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Folder);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.cb_theme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tb_mxSearches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_theme;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_Folder;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_apiKey;
        private System.Windows.Forms.Label lbl_alphavantage_Key;
        private System.Windows.Forms.TextBox tb_alphavantage_Key;
        private System.Windows.Forms.NumericUpDown tb_mxSearches;
        private System.Windows.Forms.Label lbl_maxSearch;
    }
}