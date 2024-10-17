using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using ShareManV3.databaseSelfMade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareManV3.CustomForms
{
    public partial class ShowStock : Form
    {
        private BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private CriteriaOperator shareFilter, dateFilter;

        private Share newShare = null;


        public ShowStock()
        {
            InitializeComponent();
            nUD_LastDiv.Controls[0].Visible = false;

            bindControlls();
            setFilter();
            cb_TimeRange.SelectedIndex = 3;    //Monat
            showTrendline();
            gridControl1.EmbeddedNavigator.ButtonClick += EmbeddedNavigator_ButtonClick;
        }
        private void EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.EndEdit)
            {
                xpSPH.Session.Save(xpSPH);
            }

            //nextStock();
            //prevStock();
        }

        private void bindControlls()
        {
            bindingSource.DataSource = xpShares;


            tb_Name.DataBindings.Add("Text", bindingSource, "Name", true, DataSourceUpdateMode.Never);
            tb_ISIN.DataBindings.Add("Text", bindingSource, "ISIN", true, DataSourceUpdateMode.Never);
            nUD_LastDiv.DataBindings.Add("Value", bindingSource, "LetzteDividendeValue", true, DataSourceUpdateMode.Never);
            lbl_StockName.DataBindings.Add("Text", bindingSource, "Name", true, DataSourceUpdateMode.Never);


            cb_typ.DataSource = xpTypes;
            cb_typ.DisplayMember = "ShareType";
            cb_typ.ValueMember = "STID";
            cb_typ.DataBindings.Add("SelectedValue", bindingSource, "StockType.STID", true, DataSourceUpdateMode.Never);


            cb_Exchange.DataSource = xpStockExchanges;
            cb_Exchange.DisplayMember = "Tradename";
            cb_Exchange.ValueMember = "SEID";
            cb_Exchange.DataBindings.Add("SelectedValue", bindingSource, "Börse.SEID", true, DataSourceUpdateMode.Never);


            cb_Interavl.DataSource = xpInterval;
            cb_Interavl.DisplayMember = "Interval_Name";
            cb_Interavl.ValueMember = "DID";
            cb_Interavl.DataBindings.Add("SelectedValue", bindingSource, "Div_Intervall.DID", true, DataSourceUpdateMode.Never);


        }



    }
}
