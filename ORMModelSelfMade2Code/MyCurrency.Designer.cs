﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ShareManV3.databaseSelfMade
{

    public partial class MyCurrency : PersistentBase
    {
        int fCID;
        [Key(true)]
        public int CID
        {
            get { return fCID; }
            set { SetPropertyValue<int>(nameof(CID), ref fCID, value); }
        }
        string fCurrencySymbol;
        [Indexed(Name = @"UniqueCurrencySymbol", Unique = true)]
        public string CurrencySymbol
        {
            get { return fCurrencySymbol; }
            set { SetPropertyValue<string>(nameof(CurrencySymbol), ref fCurrencySymbol, value); }
        }
        [Association(@"ShareReferencesMyCurrency")]
        public IList<Share> Shares { get { return GetList<Share>(nameof(Shares)); } }
    }

}
