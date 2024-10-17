using Newtonsoft.Json.Linq;
using ShareManV3.CustomForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public class StockData          //Wie record in delphi
{
    public string symbol { get; set; }
    public string name { get; set; }
    public string currency { get; set; }
    public string exchange { get; set; }
    public string mic_code { get; set; }
    public string country { get; set; }
    public string type { get; set; }
}

namespace ShareManV3
{
    public class StockAPI
    {
        private String APIKey;
        private ProgressShower ps;
        private DBHelper dbHelper;
        private Settings settings;

        public StockAPI(DBHelper db, String APIKey, Settings Settings)
        {
            this.APIKey = APIKey;
            dbHelper = db;
            settings = Settings;
        }

        public Task refreshAll()
        {
            ps = new ProgressShower("Update Stocks");


            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;


            worker.DoWork += workerTask;
            worker.RunWorkerCompleted += workFinished;
            worker.ProgressChanged += workUpate;

            worker.RunWorkerAsync();


            ps.Show();
            return null;
        }

        private void workerTask(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            worker.ReportProgress(0);

            string url = "https://api.twelvedata.com/stocks";
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            try
            {
                //response = client.GetAsync(url).Result;

                //response.EnsureSuccessStatusCode();

                //string responseBody = response.Content.ReadAsStringAsync().Result;
                string responseBody = File.ReadAllText("APIResponse.txt");

                JObject jsonResponse = JObject.Parse(responseBody);
                JArray dataArray = (JArray)jsonResponse["data"];
                List<StockData> stockList = dataArray.ToObject<List<StockData>>();
                worker.ReportProgress(50);
                //dbHelper.UpdateStockIndex(stockList);
                worker.ReportProgress(100);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void workFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            ps.Close();
        }

        private void workUpate(object sender, ProgressChangedEventArgs e)
        {
            ps.getPB().Value = e.ProgressPercentage;
        }

        public JArray downloadStock(String symbol)
        {
            using (var client = new HttpClient())
            {
                String url = $"https://api.twelvedata.com/time_series?start_date=1970-12-12&symbol={symbol}&interval=1day&apikey={settings.Api_Key}";

                try
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    JObject jsonResponse = JObject.Parse(response.Content.ReadAsStringAsync().Result);

                    JArray valueArray = (JArray)jsonResponse["values"];


                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return valueArray;
                    }
                    else
                    {
                        throw new Exception($"HTTP Fehler code: {response.StatusCode}");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Only debug: \n Fehler : { ex.Message }");
                    return new JArray();
                }

            }
        }

    }
}
