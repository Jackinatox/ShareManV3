using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareManV3
{
    public class DataLoader
    {
        protected List<Stock_Price_History> SPHsToAdd;
        protected UnitOfWork localUOW;


        public DataLoader()
        {
            SPHsToAdd = new List<Stock_Price_History>();
            localUOW = new UnitOfWork();
        }

        public void writeData()
        {
            int i = 0;
            using (var uow = new UnitOfWork())
            {
                foreach (var stockPriceHistory in SPHsToAdd)
                {
                    uow.Save(stockPriceHistory);
                    i++;

                    if (i % 100 == 0)
                    {
                        uow.CommitChanges();
                    }
                }

                uow.CommitChanges();
            }
        }
    }
}
