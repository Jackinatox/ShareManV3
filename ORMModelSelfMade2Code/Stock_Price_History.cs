using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ShareManV3.databaseSelfMade
{

    public partial class Stock_Price_History
    {
        public Stock_Price_History(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
