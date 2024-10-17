using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShareManV3
{
    public partial class StockList : UserControl
    {
        private List<Stock> stockList = new List<Stock>();
        public DBHelper dbh { get; set; }

        public StockList()
        {
            InitializeComponent();
        }

        public void addStock(Stock st)
        {
            st.Width = flPanel.ClientSize.Width;
            st.Anchor = AnchorStyles.Left;
            flPanel.Controls.Add(st);
            stockList.Add(st);
        }

        public void addStock(List<Stock> stocks)
        {
            flPanel.Controls.AddRange(stocks.ToArray());
            stockList.AddRange(stocks);

            //stockList[0].Hide();
        }

        private void flPanel_Resize(object sender, EventArgs e)
        {
            foreach (Stock st in stockList)
                {
                st.Width = flPanel.ClientSize.Width;
            }
        }

        private void SearchStocks(string searchTerm)
        {
            foreach (Stock st in stockList)
            {                
                if (st != null)
                {
                    if (st.Name.ToLower().Contains(searchTerm.ToLower())) //||
                    {
                        st.Visible = true; // Show the control
                    }
                    else
                    {
                        st.Visible = false; // Hide the control
                    }
                }
            }
            flPanel.Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchStocks(textBox1.Text);
        }
    }
}
