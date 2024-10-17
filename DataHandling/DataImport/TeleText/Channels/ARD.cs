using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using ShareManV3.DataHandling.DataStructs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShareManV3.DataHandling.DataImport.TeleText.Channels
{
    internal class ARD : Channel
    {
        public static bool CheckDate(string line, ref DateTime date)
        {

            try
            {
                string pattern = @"^.\d{2}\.\d{2}.\d{2}\s{2}\d{2}:\d{2}\s{4}Geld\s{3}Brief\s{2}Vortag";
                if (Regex.IsMatch(line, pattern))
                {
                    string sub = line.Substring(1, 15);
                    date = DateTime.ParseExact(sub, "dd.MM.yy  HH:mm", CultureInfo.InvariantCulture);
                    date = date.Date;
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
            string pattern = @"^\s.{15}.{5}\.\d{2}.{5}\.\d{2}.{5}\.\d{2}";
            return Regex.IsMatch(line, pattern);
        }

        public static void LoadStock(string line, ref DateTime date, ref List<Share> AllShares, ref UnitOfWork localUOW, ref List<Stock_Price_History> SPHsToAdd)
        {
            try
            {
                string telName = line.Substring(1, 15);
                telName = telName.TrimEnd();

                string temp = line.Substring(17, 7);

                internalList.Add(new SPH(telName, date, Convert.ToDouble(temp)));
            }
            catch (Exception)
            {

            }
        }
    }
}


