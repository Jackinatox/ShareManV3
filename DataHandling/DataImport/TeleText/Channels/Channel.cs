using DevExpress.Xpo;
using ShareManV3.databaseSelfMade;
using ShareManV3.DataHandling.DataStructs;
using System.Collections.Generic;
using System.Linq;

namespace ShareManV3.DataHandling.DataImport.TeleText.Channels
{
    internal class Channel
    {
        static protected List<SPH> internalList = new List<SPH>();

        static internal void commit()
        {
            var AllShares = new List<Share>();

            int i = 0;
            using (var uow = new UnitOfWork())
            {
                XPCollection<Share> Shares = new XPCollection<Share>(uow);
                AllShares = Shares.ToList();

                foreach (var loaded in internalList)
                {
                    i++;
                    Share share = AllShares.FirstOrDefault(sh => sh.TeleTextName == loaded.teleName);
                    

                    if (share != null)
                    {
                        Stock_Price_History existingSPH = uow.Query<Stock_Price_History>()
                              .FirstOrDefault(sph => sph.share.ID == share.ID && sph.Date == loaded.date);

                        if (existingSPH != null)
                        {
                            existingSPH.Price = loaded.price;
                        }
                        else
                        {
                            Stock_Price_History newSPH = new Stock_Price_History(uow);
                            newSPH.share = share;
                            newSPH.Date = loaded.date;
                            newSPH.Price = loaded.price;
                            uow.CommitChanges();
                        }
                    }
                }
                uow.CommitChanges();
            }
            internalList.Clear();
        }
    }
}
