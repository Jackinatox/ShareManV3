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
    public partial class Stock : UserControl
    {
        public String Name { get; set; }
        private string symbol;
        
        public Stock(String name, double today, double week, double month)
        {
            InitializeComponent();

            lblName.Text = name;
            lblToday.Text = today.ToString();
            lblWeek.Text = week.ToString();
            lblMonth.Text = month.ToString();
            Name = name;
        }
    }
}
