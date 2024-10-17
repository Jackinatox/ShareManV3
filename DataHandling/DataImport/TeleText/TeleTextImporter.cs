using DevExpress.CodeParser;
using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareManV3.DataHandling.DataImport.TeleText.Channels;

namespace ShareManV3.DataHandling.DataImport
{
    public class TeleTextImporter : DataLoader
    {
        private String Sender;
        private DateTime date;
        private List<Share> AllShares;
        int debugCounter = 0;


        public TeleTextImporter(String path, Share share)
        {
            localUOW = new UnitOfWork();

            XPCollection<Share> Shares = new XPCollection<Share>(localUOW);
            AllShares = Shares.ToList();


            if (Directory.EnumerateFileSystemEntries(path).Any())
            {
                DoImport(path);
            }
            else
            {
                MessageBox.Show("Folder is empty");
            }
        }

        private void DoImport(String path)
        {
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {
                debugCounter = 0;
                ScannFile(file);
            }
        }

        private void ScannFile(String file)
        {
            int lineC = 0;
            string[] FileLines = File.ReadAllLines(file, Encoding.ASCII);


            foreach (String line in FileLines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    processLine(line);
                }
                debugCounter++;
            }
        }

        private bool processLine(String line)
        {
            if (!checkSender(line))
            {
                switch (Sender)
                {
                            //I could move the three methods in the class, but i still think there should be a unified way to 
                            //call based on a unified identifier not the IF
                    case "ZDF":
                        if (!ZDF.CheckDate(line, ref date))
                        {
                            if (ZDF.CheckShare(line))
                            {
                                ZDF.LoadStock(line, ref date, ref AllShares, ref localUOW, ref SPHsToAdd);
                            }
                        }
                        break;

                    case "ARD":
                        if (!ARD.CheckDate(line, ref date))
                        {
                            if (ARD.CheckShare(line))
                            {
                                ARD.LoadStock(line, ref date, ref AllShares, ref localUOW, ref SPHsToAdd);
                            }
                        }

                        break;
                    default:
                        throw new InvalidOperationException("Sender was not defined");
                }
            }

            return false;
        }

        private bool checkSender(String line)
        {
            if (line.Contains("ARD Text"))
            {
                Sender = "ARD";
                return true;
            }
            else if (line.Contains("ZDFtext"))
            {
                Sender = "ZDF";
                return true;
            }

            return false;
        }
    }
}
