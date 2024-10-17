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
    public partial class ProgressShower : Form
    {
        public int progress { set { progressBar1.Value = value; } get { return progressBar1.Value; } }
        public ProgressShower(String Name)
        {
            InitializeComponent();
            tb_title.Text = Name;
            progressBar1.Maximum = 100;
        }

        public ProgressBar getPB()
        {
            return this.progressBar1;
        }
        public void setProgress(int value)
        {
            progressBar1.Value = value;
        }
    }
}
