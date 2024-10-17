using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using ShareManV3.DataHandling.DataStructs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ShareManV3.DataHandling.DataImport.TeleText.Channels
{
    internal class ZDF : Channel
    {
        public static bool CheckDate(string line, ref DateTime date)
        {
            try
            {
                if (line.EndsWith("Datum"))
                {
                    string sub = line.Substring(1, 15);
                    date = DateTime.ParseExact(sub, "dd.MM.yy, HH:mm", CultureInfo.InvariantCulture);
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
            string pattern = @"^.{17},.{7},.{11}:..";
            return Regex.IsMatch(line, pattern);
        }

        public static void LoadStock(string line, ref DateTime date, ref List<Share> AllShares, ref UnitOfWork inheritedUOW, ref List<Stock_Price_History> SPHsToAdd, int debugCounter)
        {
            try
            {
                string telName = line.Substring(1, 11);
                telName = telName.TrimEnd();

                string temp = line.Substring(11, 9);

                internalList.Add(new SPH(telName, date, Convert.ToDouble(temp)));
            }
            catch (Exception)
            {

            }
        }
    }
}
