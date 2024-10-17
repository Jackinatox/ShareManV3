using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareManV3.DataHandling.DataImport.TeleText.Channels
{
    public interface IChannel
    {
        bool CheckDate(string line, ref DateTime date);
        bool CheckShare(string line);
        bool LoadStock(string line);
    }
}
