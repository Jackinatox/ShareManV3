using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ShareManV3.databaseSelfMade
{

    public partial class StockExchange
    {
        public StockExchange(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
