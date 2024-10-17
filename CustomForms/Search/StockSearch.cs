using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace ShareManV3
{
    public partial class StockSearch : UserControl 
    {

        private List<Stock> list = new List<Stock>();
        private List<Stock> cplist = new List<Stock>();

        public DBHelper dbh { get; set; }
        public Settings settings { get; set; }

        public StockSearch()
        {
            InitializeComponent();
        }

        public void addStock(Stock st)
        {
            st.Width = flPanel.ClientSize.Width;
            st.Anchor = AnchorStyles.Left;
            flPanel.Controls.Add(st);
            list.Add(st);
        }

        private void flPanel_Resize(object sender, EventArgs e)
        {
            foreach (Stock st in list)
                {
                st.Width = flPanel.ClientSize.Width;
            }
        }

        private void SearchStocks(string searchTerm)
        {            
            //requesting new data
            
            //clearing the panel meanwhile
            flPanel.Controls.Clear();
            Task task = Task.Run(() => webSearch(tb_search.Text));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchStocks(tb_search.Text);
        }


        private void webSearch(string searchTerm)
        {
                //HttpResponseMessage response;
                string url = "https://api.twelvedata.com/symbol_search?symbol=" + searchTerm;

                using (var client = new HttpClient())
                {
                    var uri = new Uri(url);

                    var result = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;

                    JObject json = JObject.Parse(result);
                    JArray bestmatches = (JArray)json["data"];

                    if (bestmatches.Count > 0)
                    {
                        int i = 0;
                        foreach (var bestMatch in bestmatches)
                        {
                            if (i < settings.maxSearches)
                            {
                                Stock st = new Stock(bestMatch["instrument_name"].ToString(), 2, 2, 2);
                                st.Width = flPanel.ClientSize.Width;
                                st.Anchor = AnchorStyles.Left;
                                cplist.Add(st);
                                i++;
                            }
                        }
                    }


                flPanel.Invoke((MethodInvoker)delegate
                {
                    flPanel.Controls.AddRange(cplist.ToArray());
                });

                cplist.Clear();

                }
        }
    }
}
