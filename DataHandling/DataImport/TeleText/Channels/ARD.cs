using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShareManV3.DataHandling.DataImport.TeleText.Channels
{
    internal class ARD
    {
        public static bool CheckDate(string line, ref DateTime date)
        {

            return false;
        }

        public static bool CheckShare(string line)
        {
            string pattern = @"^.{17},.{7},.{11}:..";
            return Regex.IsMatch(line, pattern);
        }

        public static bool LoadStock(string line, ref DateTime date, ref List<Share> AllShares, ref UnitOfWork localUOW, ref List<Stock_Price_History> SPHsToAdd)
        {
    
            return false;
        }
    }
}


