namespace ShareManV3
{
    partial class StockList
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
            this.components = new System.ComponentModel.Container();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stockTopBar1 = new ShareManV3.StockTopBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanel.Location = new System.Drawing.Point(0, 56);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(776, 301);
            this.flPanel.TabIndex = 1;
            this.flPanel.WrapContents = false;
            this.flPanel.Resize += new System.EventHandler(this.flPanel_Resize);
            // 
            // stockTopBar1
            // 
            this.stockTopBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockTopBar1.Location = new System.Drawing.Point(0, 0);
            this.stockTopBar1.Name = "stockTopBar1";
            this.stockTopBar1.Size = new System.Drawing.Size(776, 56);
            this.stockTopBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.stockTopBar1);
            this.Name = "StockList";
            this.Size = new System.Drawing.Size(776, 357);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StockTopBar stockTopBar1;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
