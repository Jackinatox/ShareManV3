using DevExpress.Xpo;
using ShareManV3.CustomForms;
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
using ShareManV3.CustomForms.ImportForms; 

namespace ShareManV3
{
    public partial class Form1 : Form
    {
        private Settings _settings;
        private readonly string _settingsFilePath = "settings.json"; // Path to the settings file
        StockAPI API;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var D = new ShowStockk();
            D.Show();
        }

        private async Task loadLocalStocks()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                XPCollection<Share> Shares = new XPCollection<Share>(uow);
                List<Stock> stockList = new List<Stock>();

                // Define today's date, one week ago, and one month ago
                DateTime today = DateTime.Today;
                DateTime oneWeekAgo = today.AddDays(-30);
                DateTime oneMonthAgo = today.AddMonths(-12);

                foreach (var st in Shares)
                {
                    // Fetch stock prices for each share at the relevant dates
                    double todayPrice = uow.Query<Stock_Price_History>()
                        .Where(p => p.share.ID == st.ID && p.Date.Date == today.Date)
                        .Select(p => p.Price)
                        .FirstOrDefault();

                    double weekAgoPrice = uow.Query<Stock_Price_History>()
                        .Where(p => p.share == st && p.Date.Date == oneWeekAgo.Date)
                        .Select(p => p.Price)
                        .FirstOrDefault();

                    double monthAgoPrice = uow.Query<Stock_Price_History>()
                        .Where(p => p.share == st && p.Date.Date == oneMonthAgo.Date)
                        .Select(p => p.Price)
                        .FirstOrDefault();


                    Stock newSt = new Stock(st.Name, todayPrice, weekAgoPrice, monthAgoPrice);
                    newSt.Width = ClientSize.Width;
                    newSt.Anchor = AnchorStyles.Left;
                    stockList.Add(newSt);
                }

                this.stockList.Invoke(new Action(() =>
                {
                    this.stockList.addStock(stockList);
                }));
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm(_settings, _settingsFilePath, API))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            var imp = new ImportForm();
            imp.ShowDialog();
        }
    }
}
