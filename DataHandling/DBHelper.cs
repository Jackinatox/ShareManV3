using Newtonsoft.Json.Linq;
using ShareManV3.CustomForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareManV3
{
    public class DBHelper
    {
        private string _connectionString;
        private StockAPI _stockAPI;
        public Settings settings { get; set; }
        public DBHelper(string dbPath, StockAPI API)
        {
            // Create a connection string for the SQLite database
            _connectionString = $"Data Source={dbPath};";
            _stockAPI = API;

            if (false)
            {
                CreateTable();
                //exampleData();
            }
        }
        public void CreateTable()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string createStock_Exchange = @"
                CREATE TABLE Stock_Exchange (
                    SEID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    TradeName VARCHAR(50),
                    Ort VARCHAR(60)
                );";

                string createStock_Type = @"
                CREATE TABLE Stock_Type (
                    STID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    ShareType VARCHAR(50) UNIQUE NOT NULL
                );";

                string createCurrency = @"
                CREATE TABLE Currency (
                    CID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    CurrencyID VARCHAR(3) UNIQUE NOT NULL
                );";

                string createDiv_Intervall = @"
                CREATE TABLE Div_Intervall (
                    DID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    DivPeriod VARCHAR(20) UNIQUE NOT NULL
                );";

                string createshare = @"
                CREATE TABLE share (
                    ID INTEGER PRIMARY KEY NOT NULL,
                    ISIN VARCHAR(12) NOT NULL,
                    Name VARCHAR(50) UNIQUE NOT NULL,
                    WKN VARCHAR(6),
                    Ausschüttend_Thesaurierend BOOLEAN,
                    Letzte_Hauptversammlung DATE,
                    Letzte_Dividende_D DATE,
                    Letzte_Dividende_V FLOAT, 
                    Notes VARCHAR(50),
                    Div_Intervall INTEGER,
                    Börse INTEGER,
                    Currency VARCHAR(3),
                    Stock_Type INTEGER,
    
                    FOREIGN KEY (Börse) REFERENCES Stock_Exchange(SEID),
                    FOREIGN KEY (Currency) REFERENCES Currency(CID),
                    FOREIGN KEY (Stock_Type) REFERENCES Stock_Type(STID),
                    FOREIGN KEY (Div_Intervall) REFERENCES Div_Intervall(DID)

                );";

                string createstock_price_history = @"
                CREATE TABLE stock_price_history (
                    SHID INTEGER PRIMARY KEY NOT NULL,
                    stock INTEGER,
                    SDate Date,
                    Price REAL,
                    Notes VARCHAR(80),

                    FOREIGN KEY (stock) REFERENCES share(ID)
                );";


                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = createStock_Type;
                cmd.ExecuteNonQuery();
                cmd.CommandText = createStock_Exchange;
                cmd.ExecuteNonQuery();
                cmd.CommandText = createCurrency;
                cmd.ExecuteNonQuery();
                cmd.CommandText = createDiv_Intervall;
                cmd.ExecuteNonQuery();
                cmd.CommandText = createshare;
                cmd.ExecuteNonQuery();
                cmd.CommandText = createstock_price_history;
                cmd.ExecuteNonQuery();

            }
        }

        public void exampleData()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                // Start a transaction to group multiple insertions
                // using (var transaction = connection.BeginTransaction())
                // {
                using (var cmd = connection.CreateCommand())
                {
                    // Insert data into Stock_Exchange table
                    cmd.CommandText = @"
                            INSERT INTO Stock_Exchange (TradeName, Ort) VALUES (@TradeName, @Ort);
                        ";
                    cmd.Parameters.Add(new SQLiteParameter("@TradeName", ""));
                    cmd.Parameters.Add(new SQLiteParameter("@Ort", ""));

                    // Insert multiple rows
                    var stockExchanges = new[]
                    {
                            new { TradeName = "NASDAQ", Ort = "New York" },
                            new { TradeName = "Gettex", Ort = "München" },
                            new { TradeName = "Quotrix ", Ort = "Düsseldorf " }
                        };

                    foreach (var exchange in stockExchanges)
                    {
                        cmd.Parameters["@TradeName"].Value = exchange.TradeName;
                        cmd.Parameters["@Ort"].Value = exchange.Ort;
                        cmd.ExecuteNonQuery();
                    }
                }
                //}
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string insertShareData = @"
            INSERT INTO share (ISIN, Name, WKN, Ausschüttend_Thesaurierend, Letzte_Hauptversammlung, Letzte_Dividende_D, Letzte_Dividende_V, Notes, Div_Intervall, Börse, Currency, Stock_Type)
            VALUES
            (@ISIN1, @Name1, @WKN1, @Ausschüttend1, @Hauptversammlung1, @DividendeD1, @DividendeV1, @Notes1, @DivIntervall1, @Börse1, @Currency1, @StockType1),
            (@ISIN2, @Name2, @WKN2, @Ausschüttend2, @Hauptversammlung2, @DividendeD2, @DividendeV2, @Notes2, @DivIntervall2, @Börse2, @Currency2, @StockType2);";

                using (var command = new SQLiteCommand(insertShareData, connection))
                {
                    // Sample Data for the first share
                    command.Parameters.AddWithValue("@ISIN1", "US0378331005"); // Apple Inc.
                    command.Parameters.AddWithValue("@Name1", "Apple Inc.");
                    command.Parameters.AddWithValue("@WKN1", "865985");
                    command.Parameters.AddWithValue("@Ausschüttend1", true);
                    command.Parameters.AddWithValue("@Hauptversammlung1", DateTime.Parse("2023-02-10"));
                    command.Parameters.AddWithValue("@DividendeD1", DateTime.Parse("2023-03-01"));
                    command.Parameters.AddWithValue("@DividendeV1", 0.23f);
                    command.Parameters.AddWithValue("@Notes1", "Tech company");
                    command.Parameters.AddWithValue("@DivIntervall1", "Quarterly");
                    command.Parameters.AddWithValue("@Börse1", 1); // Assuming SEID 1 for NYSE
                    command.Parameters.AddWithValue("@Currency1", "USD");
                    command.Parameters.AddWithValue("@StockType1", 1); // Assuming STID 1 for Common Stock

                    // Sample Data for the second share
                    command.Parameters.AddWithValue("@ISIN2", "US5949181045"); // Microsoft Corp.
                    command.Parameters.AddWithValue("@Name2", "Microsoft Corp.");
                    command.Parameters.AddWithValue("@WKN2", "870747");
                    command.Parameters.AddWithValue("@Ausschüttend2", true);
                    command.Parameters.AddWithValue("@Hauptversammlung2", DateTime.Parse("2023-01-20"));
                    command.Parameters.AddWithValue("@DividendeD2", DateTime.Parse("2023-02-01"));
                    command.Parameters.AddWithValue("@DividendeV2", 0.56f);
                    command.Parameters.AddWithValue("@Notes2", "Software company");
                    command.Parameters.AddWithValue("@DivIntervall2", "Quarterly");
                    command.Parameters.AddWithValue("@Börse2", 1); // Assuming SEID 1 for NYSE
                    command.Parameters.AddWithValue("@Currency2", "USD");
                    command.Parameters.AddWithValue("@StockType2", 1); // Assuming STID 1 for Common Stock

                    command.ExecuteNonQuery();
                }
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string insertStockPriceHistoryData = @"
            INSERT INTO stock_price_history (SPHID, SDate, Price, Notes)
            VALUES
            (@SPHID1, @Date1, @Price1, @Notes1),
            (@SPHID1, @Date2, @Price2, @Notes2),
            (@SPHID1, @Date3, @Price3, @Notes3),
            (@SPHID2, @Date4, @Price4, @Notes4),
            (@SPHID2, @Date5, @Price5, @Notes5),
            (@SPHID2, @Date6, @Price6, @Notes6);";

                using (var command = new SQLiteCommand(insertStockPriceHistoryData, connection))
                {
                    // Stock price history for Apple Inc. (Assuming SID 1)
                    command.Parameters.AddWithValue("@SPHID1", 1);
                    command.Parameters.AddWithValue("@Date1", DateTime.Parse("2024-08-01"));
                    command.Parameters.AddWithValue("@Price1", 150.25m);
                    command.Parameters.AddWithValue("@Notes1", "Steady growth");

                    command.Parameters.AddWithValue("@Date2", DateTime.Parse("2024-08-02"));
                    command.Parameters.AddWithValue("@Price2", 152.30m);
                    command.Parameters.AddWithValue("@Notes2", "Minor increase");

                    command.Parameters.AddWithValue("@Date3", DateTime.Parse("2024-08-03"));
                    command.Parameters.AddWithValue("@Price3", 148.75m);
                    command.Parameters.AddWithValue("@Notes3", "Slight drop");

                    // Stock price history for Microsoft Corp. (Assuming SID 2)
                    command.Parameters.AddWithValue("@SPHID2", 2);
                    command.Parameters.AddWithValue("@Date4", DateTime.Parse("2024-08-01"));
                    command.Parameters.AddWithValue("@Price4", 280.50m);
                    command.Parameters.AddWithValue("@Notes4", "Steady performance");

                    command.Parameters.AddWithValue("@Date5", DateTime.Parse("2024-08-02"));
                    command.Parameters.AddWithValue("@Price5", 282.75m);
                    command.Parameters.AddWithValue("@Notes5", "Positive outlook");

                    command.Parameters.AddWithValue("@Date6", DateTime.Parse("2024-08-03"));
                    command.Parameters.AddWithValue("@Price6", 278.10m);
                    command.Parameters.AddWithValue("@Notes6", "Slight correction");

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStockIndex(List<StockData> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = $"DELETE FROM StockIndex";
                SQLiteCommand commandClear = new SQLiteCommand(sql, connection);

                commandClear.ExecuteNonQuery();

                foreach (var stock in list)
                {
                    // Perform any post-processing on stock data here
                    // For example, trim strings, validate data, etc.

                    // Prepare SQL command for insertion
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = "INSERT INTO StockIndex (symbol, name, currency, exchange, mic_code, country, type) VALUES (@symbol, @name, @currency, @exchange, @mic_code, @country, @type)";
                        command.Parameters.AddWithValue("@symbol", stock.symbol);
                        command.Parameters.AddWithValue("@name", stock.name);
                        command.Parameters.AddWithValue("@currency", stock.currency);
                        command.Parameters.AddWithValue("@exchange", stock.exchange);
                        command.Parameters.AddWithValue("@mic_code", stock.mic_code);
                        command.Parameters.AddWithValue("@country", stock.country);
                        command.Parameters.AddWithValue("@type", stock.type);

                        // Add parameters for other columns as needed

                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }   //Nutzlos, ich benutze einfach den Search endpoint


        public DataTable getDataTable(string symbol)
        {
            //Getting Data from API when no recods available
            if (!isDataCached(symbol))
            {
                getUnCached(symbol);
            }

            //getting DataTable
            DataTable dataTable = new DataTable();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT SDate, Price, Notes 
                    FROM stock_price_history 
                    WHERE symbol = @symbol
                    ORDER BY SDate ASC;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add the parameter to the command
                    command.Parameters.AddWithValue("@symbol", symbol);

                    // Use the command with the parameter in the adapter
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }

        }

        private bool isDataCached(String symbol)
        {

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT SDate, Price, Notes 
                    FROM stock_price_history 
                    WHERE symbol = @symbol
                    ORDER BY SDate ASC;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add the parameter to the command
                    command.Parameters.AddWithValue("@symbol", symbol);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private void getUnCached(String symbol)
        {
            if (!primaryExists(symbol))
                createPrimary(symbol);

            JArray valueArray = _stockAPI.downloadStock(symbol);

            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                foreach (var value in valueArray)
                {
                    DateTime sDate = DateTime.ParseExact(value["datetime"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    //decimal open = value["open"].ToObject<decimal>();
                    //decimal high = value["high"].ToObject<decimal>();
                    //decimal low = value["low"].ToObject<decimal>();
                    decimal close = value["close"].ToObject<decimal>();
                    //long volume = value["volume"].ToObject<long>();

                    string insertQuery = @"
                                INSERT INTO stock_price_history (symbol, SDate, Price)
                                VALUES (@symbol, @datetime, @close)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@symbol", symbol);
                        cmd.Parameters.AddWithValue("@datetime", sDate);
                        cmd.Parameters.AddWithValue("@close", close);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private bool primaryExists(String symbol)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT symbol 
                    FROM stock_price_history 
                    WHERE symbol = @symbol
                    ORDER BY SDate ASC;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add the parameter to the command
                    command.Parameters.AddWithValue("@symbol", symbol);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        public async Task getstuff()
        {
            //using (var client = new HttpClient())
            //{
            //    String url = $"https://api.twelvedata.com/time_series?start_date=1970-12-12&symbol=agnc&interval=1day&apikey={settings.Api_Key}";

            //    try
            //    {
            //        HttpResponseMessage response = await client.GetAsync(url);
            //        JObject jsonResponse = JObject.Parse(response.Content.ReadAsStringAsync().Result);

            //        JArray valueArray = (JArray)jsonResponse["values"];



            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Only debug: \n Fehler : {ex.Message}");
            //    }

            //}            

            Thread.Sleep(5000);
        }
        
        private void createPrimary(String symbol)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand(conn))
                {
                    String querry = @"INSERT INTO share 
                        (symbol, ISIN, Name, WKN, Ausschüttend_Thesaurierend, Letzte_Hauptversammlung, Letzte_Dividende_D, Letzte_Dividende_V, Notes, Div_Intervall, Börse, Currency, Stock_Type) 
                        VALUES 
                        (@symbol, @ISIN, @Name, @WKN, @Ausschüttend_Thesaurierend, @Letzte_Hauptversammlung, @Letzte_Dividende_D, @Letzte_Dividende_V, @Notes, @Div_Intervall, @Börse, @Currency, @Stock_Type);
                        ";
                    command.CommandText = querry;

                    command.Parameters.AddWithValue("@symbol", symbol);
                    command.Parameters.AddWithValue("@ISIN", "");
                    command.Parameters.AddWithValue("@Name", symbol);
                    command.Parameters.AddWithValue("@WKN", "");
                    command.Parameters.AddWithValue("@Ausschüttend_Thesaurierend", "");
                    command.Parameters.AddWithValue("@Letzte_Hauptversammlung", "");
                    command.Parameters.AddWithValue("@Letzte_Dividende_D", "");
                    command.Parameters.AddWithValue("@Letzte_Dividende_V", "");
                    command.Parameters.AddWithValue("@Notes", "");
                    command.Parameters.AddWithValue("@Div_Intervall", "");
                    command.Parameters.AddWithValue("@Börse", "");
                    command.Parameters.AddWithValue("@Currency", "");
                    command.Parameters.AddWithValue("@Stock_Type", "");
                    try { 
                        command.ExecuteNonQuery(); 
                    } catch (Exception e){
                        MessageBox.Show(e.Message);    
                    }
                    
                }

            }

        }

        public async Task<List<String>> loadCachedStocks()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT symbol
                    FROM share
                    ORDER BY symbol ASC;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    //var readerTask = command.ExecuteReaderAsync();
                    var reader = await command.ExecuteReaderAsync();
                    var symbolList = new List<String>();

                    while (reader.Read())
                    {
                        symbolList.Add(reader["symbol"].ToString());
                    }
                    return symbolList;
                }
            }
        }
    }
}


