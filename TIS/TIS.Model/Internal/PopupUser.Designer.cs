//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class PopupUser : XPCustomObject
    {
        Guid fpopupuserID;
        [Key(true)]
        public Guid popupuserID
        {
            get { return fpopupuserID; }
            set { SetPropertyValue<Guid>("popupuserID", ref fpopupuserID, value); }
        }
        Guid fpopupID;
        public Guid popupID
        {
            get { return fpopupID; }
            set { SetPropertyValue<Guid>("popupID", ref fpopupID, value); }
        }
        Guid fuserID;
        public Guid userID
        {
            get { return fuserID; }
            set { SetPropertyValue<Guid>("userID", ref fuserID, value); }
        }
    }

}