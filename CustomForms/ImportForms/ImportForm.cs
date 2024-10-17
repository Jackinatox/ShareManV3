using Microsoft.WindowsAPICodePack.Dialogs;
using ShareManV3.DataHandling.DataImport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareManV3.CustomForms.ImportForms
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
            cmb_src.SelectedIndex = 0;
            updateButton();
            pb_Bar.Style = ProgressBarStyle.Blocks;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_src.SelectedIndex)
            {
                case 0:             //TeleText
                    break;

            }

        }

        private void btn_selectPath_Click(object sender, EventArgs e)
        {
            var D = new CommonOpenFileDialog();
            D.IsFolderPicker = true;

            if (D.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tb_path.Text = D.FileName;
            }
        }

        private async void btn_import_Click(object sender, EventArgs e)
        {
            if (checkImportable())
            {
                pb_Bar.Style = ProgressBarStyle.Marquee;
                switch (cmb_src.SelectedIndex)
                {
                    case 0:             //TeleText
                        await ImportTeleText();
                        break;

                }
            }
            pb_Bar.Style = ProgressBarStyle.Blocks;
            updateButton();
        }

        private async Task ImportTeleText()
        {
            TeleTextImporter imp = new TeleTextImporter(tb_path.Text);
            await Task.Run(() => imp.Load());
            await Task.Run(() => imp.Commit());
        }

        private void updateButton()
        {
            btn_import.Enabled = checkImportable();
        }

        private bool checkImportable()
        {
            switch (cmb_src.SelectedIndex)
            {
                case 0:             //TeleText

                    try
                    {

                        return Directory.GetFiles(tb_path.Text, "*.txt").Length > 0 &&
                               true;
                    }
                    catch (Exception)
                    {


                    }

                    break;

            }
            return false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            updateButton();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
