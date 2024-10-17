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
    internal class ZDF
    {
        public static bool CheckDate(string line, ref DateTime date)
        {
            try
            {
                if (line.EndsWith("Datum"))
                {
                    string sub = line.Substring(1, 15);
                    date = DateTime.ParseExact(sub, "dd.MM.yy, HH:mm", CultureInfo.InvariantCulture);
                    //date = DateOnly.Parse(line.Substring(9));
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public static bool CheckShare(string line)
        {
            string pattern = @"^.{17},.{7},.{11}:..";
            return Regex.IsMatch(line, pattern);
        }

        public static bool LoadStock(string line, ref DateTime date, ref List<Share> AllShares, ref UnitOfWork localUOW, ref List<Stock_Price_History> SPHsToAdd)
        {
            string telName = line.Substring(1, 11);
            telName = telName.TrimEnd();
            Share share = AllShares.FirstOrDefault(sh => sh.TeleTextName == telName);

            if (share != null)
            {

                Stock_Price_History SPH = new Stock_Price_History(localUOW);
                SPH.share = share;
                SPH.Date = date;
                string temp = line.Substring(11, 9);
                SPH.Price = Convert.ToDouble(temp);
                SPHsToAdd.Add(SPH);
            }
            return false;
        }
    }
}
