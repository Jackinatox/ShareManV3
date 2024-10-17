namespace ShareManV3.CustomForms
{
    partial class ShowStock
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpSPH = new DevExpress.Xpo.XPCollection(this.components);
            this.main_session = new DevExpress.Xpo.Session(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_typ = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Interavl = new System.Windows.Forms.ComboBox();
            this.nUD_LastDiv = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Exchange = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ISIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TimeRange = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_TelName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancleEdit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_NewStock = new System.Windows.Forms.Button();
            this.lbl_StockName = new System.Windows.Forms.Label();
            this.xpShares = new DevExpress.Xpo.XPCollection(this.components);
            this.xpStockExchanges = new DevExpress.Xpo.XPCollection(this.components);
            this.xpTypes = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.xpBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpSPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_LastDiv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpShares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpStockExchanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1059, 536);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 152);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(200, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 381);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpSPH;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Div_Intervall";
            gridLevelNode3.RelationName = "Börse";
            gridLevelNode4.RelationName = "Currency";
            gridLevelNode5.RelationName = "StockType";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4,
            gridLevelNode5});
            gridLevelNode1.RelationName = "share";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(386, 381);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpSPH
            // 
            this.xpSPH.ObjectType = typeof(ShareManV3.databaseSelfMade.Stock_Price_History);
            this.xpSPH.Session = this.main_session;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colPrice,
            this.colNotes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDate
            // 
            this.colDate.Caption = "Datum";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Preis";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Notizen";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(663, 381);
            this.chartControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 101);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_typ);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cb_Interavl);
            this.tabPage1.Controls.Add(this.nUD_LastDiv);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cb_Exchange);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_ISIN);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_Name);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cb_TimeRange);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 75);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basis-Infos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_typ
            // 
            this.cb_typ.FormattingEnabled = true;
            this.cb_typ.Location = new System.Drawing.Point(391, 6);
            this.cb_typ.Name = "cb_typ";
            this.cb_typ.Size = new System.Drawing.Size(121, 21);
            this.cb_typ.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Interval";
            // 
            // cb_Interavl
            // 
            this.cb_Interavl.DisplayMember = "Intervall";
            this.cb_Interavl.FormattingEnabled = true;
            this.cb_Interavl.Location = new System.Drawing.Point(755, 48);
            this.cb_Interavl.Name = "cb_Interavl";
            this.cb_Interavl.Size = new System.Drawing.Size(93, 21);
            this.cb_Interavl.TabIndex = 11;
            this.cb_Interavl.ValueMember = "DID";
            // 
            // nUD_LastDiv
            // 
            this.nUD_LastDiv.DecimalPlaces = 3;
            this.nUD_LastDiv.Location = new System.Drawing.Point(755, 8);
            this.nUD_LastDiv.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_LastDiv.Name = "nUD_LastDiv";
            this.nUD_LastDiv.Size = new System.Drawing.Size(93, 20);
            this.nUD_LastDiv.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dividende";
            // 
            // cb_Exchange
            // 
            this.cb_Exchange.DisplayMember = "Tradename";
            this.cb_Exchange.FormattingEnabled = true;
            this.cb_Exchange.Location = new System.Drawing.Point(391, 48);
            this.cb_Exchange.Name = "cb_Exchange";
            this.cb_Exchange.Size = new System.Drawing.Size(121, 21);
            this.cb_Exchange.TabIndex = 7;
            this.cb_Exchange.ValueMember = "SEID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Börse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Typ";
            // 
            // tb_ISIN
            // 
            this.tb_ISIN.Location = new System.Drawing.Point(85, 48);
            this.tb_ISIN.Name = "tb_ISIN";
            this.tb_ISIN.Size = new System.Drawing.Size(200, 20);
            this.tb_ISIN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISIN";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(85, 8);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(200, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // cb_TimeRange
            // 
            this.cb_TimeRange.Dock = System.Windows.Forms.DockStyle.Right;
            this.cb_TimeRange.FormattingEnabled = true;
            this.cb_TimeRange.Items.AddRange(new object[] {
            "Alles",
            "5 Jahre",
            "1 Jahr",
            "1 Monat",
            "1 Woche"});
            this.cb_TimeRange.Location = new System.Drawing.Point(927, 3);
            this.cb_TimeRange.Name = "cb_TimeRange";
            this.cb_TimeRange.Size = new System.Drawing.Size(115, 21);
            this.cb_TimeRange.TabIndex = 0;
            this.cb_TimeRange.Text = "Alles";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 75);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Identifiers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_TelName
            // 
            this.tb_TelName.Location = new System.Drawing.Point(137, 11);
            this.tb_TelName.Name = "tb_TelName";
            this.tb_TelName.Size = new System.Drawing.Size(100, 20);
            this.tb_TelName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "TeleText Name";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 42);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(859, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 30);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(65, 3);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(24, 23);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "🗑";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_cancleEdit
            // 
            this.btn_cancleEdit.Location = new System.Drawing.Point(126, 3);
            this.btn_cancleEdit.Name = "btn_cancleEdit";
            this.btn_cancleEdit.Size = new System.Drawing.Size(24, 23);
            this.btn_cancleEdit.TabIndex = 5;
            this.btn_cancleEdit.Text = "✖";
            this.btn_cancleEdit.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(96, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(24, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "✓";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_NewStock
            // 
            this.btn_NewStock.Location = new System.Drawing.Point(35, 3);
            this.btn_NewStock.Name = "btn_NewStock";
            this.btn_NewStock.Size = new System.Drawing.Size(24, 23);
            this.btn_NewStock.TabIndex = 3;
            this.btn_NewStock.Text = "+";
            this.btn_NewStock.UseVisualStyleBackColor = true;
            // 
            // lbl_StockName
            // 
            this.lbl_StockName.AutoSize = true;
            this.lbl_StockName.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockName.Location = new System.Drawing.Point(13, 11);
            this.lbl_StockName.Name = "lbl_StockName";
            this.lbl_StockName.Size = new System.Drawing.Size(44, 19);
            this.lbl_StockName.TabIndex = 0;
            this.lbl_StockName.Text = "label1";
            this.lbl_StockName.UseMnemonic = false;
            // 
            // xpShares
            // 
            this.xpShares.ObjectType = typeof(ShareManV3.databaseSelfMade.Share);
            this.xpShares.Session = this.main_session;
            // 
            // xpStockExchanges
            // 
            this.xpStockExchanges.ObjectType = typeof(ShareManV3.databaseSelfMade.StockExchange);
            this.xpStockExchanges.Session = this.main_session;
            // 
            // xpTypes
            // 
            this.xpTypes.ObjectType = typeof(ShareManV3.databaseSelfMade.Stock_type);
            this.xpTypes.Session = this.main_session;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(ShareManV3.databaseSelfMade.Div_Intervall);
            this.xpCollection1.Session = this.main_session;
            // 
            // xpBindingSource
            // 
            this.xpBindingSource.DataSource = this.xpShares;
            // 
            // ShowStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 536);
            this.Name = "ShowStock";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpSPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_LastDiv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpShares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpStockExchanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cb_typ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Interavl;
        private System.Windows.Forms.NumericUpDown nUD_LastDiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Exchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ISIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TimeRange;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_TelName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancleEdit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_NewStock;
        private System.Windows.Forms.Label lbl_StockName;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.Xpo.Session main_session;
        private DevExpress.Xpo.XPCollection xpSPH;
        private DevExpress.Xpo.XPCollection xpShares;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.Xpo.XPCollection xpStockExchanges;
        private DevExpress.Xpo.XPCollection xpTypes;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.XPBindingSource xpBindingSource;
    }
}