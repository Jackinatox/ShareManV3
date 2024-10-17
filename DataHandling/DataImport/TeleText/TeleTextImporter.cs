using DevExpress.CodeParser;
using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ShareManV3.DataHandling.DataImport.TeleText.Channels;

namespace ShareManV3.DataHandling.DataImport
{
    public class TeleTextImporter
    {
        private String path;
        private String Sender;
        private DateTime date;
        private List<Share> AllShares;
        public int debugCounter = 0;
        protected List<Stock_Price_History> SPHsToAdd;
        protected UnitOfWork localUOW;



        public TeleTextImporter(String Path)
        {
            SPHsToAdd = new List<Stock_Price_History>();

            path = Path;


            if (!Directory.EnumerateFileSystemEntries(path).Any())
            {
                throw new Exception("Folder is empty");
            }
        }

        public void Load()
        {
            DoImport(path);
        }

        public void Commit()
        {
            Channel.commit();
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
            string[] FileLines = File.ReadAllLines(file, Encoding.GetEncoding(437));


            foreach (String line in FileLines)
            {
                debugCounter++;
                if (!string.IsNullOrEmpty(line))
                {
                    processLine(line);
                }
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
                                ZDF.LoadStock(line, ref date, ref AllShares, ref localUOW, ref SPHsToAdd, debugCounter);

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
