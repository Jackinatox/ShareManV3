using ShareManV3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareManV3
{
    public partial class SettingsForm : Form
    {
        private Settings _settings;
        private string _settingsFilePath;
        private StockAPI _api;



        public SettingsForm(Settings settings, string settingsFilePath, StockAPI api)
        {
            InitializeComponent();
            _settings = settings;
            _settingsFilePath = settingsFilePath;
            _api = api;

            // Initialize controls with current settings
            load();
        }
        private void load()
        {
            tb_path.Text = _settings.Path;
            tb_apiKey.Text = _settings.Api_Key;
            tb_alphavantage_Key.Text = _settings.alphavantage_Key;
            tb_mxSearches.Value = _settings.maxSearches;
        }

        private void apply()
        {
            _settings.Path = tb_path.Text;
            _settings.Api_Key = tb_apiKey.Text;
            _settings.alphavantage_Key = tb_alphavantage_Key.Text;
            _settings.maxSearches = Convert.ToInt32(tb_mxSearches.Value);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // Close the form
            apply();
            _settings.Save(_settingsFilePath);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Folder_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = folderDialog.SelectedPath;        
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
