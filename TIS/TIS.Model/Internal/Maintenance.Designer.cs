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

    public partial class Maintenance : XPCustomObject
    {
        Guid fmaintID;
        [Key(true)]
        public Guid maintID
        {
            get { return fmaintID; }
            set { SetPropertyValue<Guid>("maintID", ref fmaintID, value); }
        }
        Guid fmatID;
        public Guid matID
        {
            get { return fmatID; }
            set { SetPropertyValue<Guid>("matID", ref fmatID, value); }
        }
        string fStartMaintenance;
        [Size(14)]
        public string StartMaintenance
        {
            get { return fStartMaintenance; }
            set { SetPropertyValue<string>("StartMaintenance", ref fStartMaintenance, value); }
        }
        string fRemark;
        [Size(255)]
        public string Remark
        {
            get { return fRemark; }
            set { SetPropertyValue<string>("Remark", ref fRemark, value); }
        }
        Guid fmaintvehID;
        public Guid maintvehID
        {
            get { return fmaintvehID; }
            set { SetPropertyValue<Guid>("maintvehID", ref fmaintvehID, value); }
        }
        Guid fempIDExecutor;
        public Guid empIDExecutor
        {
            get { return fempIDExecutor; }
            set { SetPropertyValue<Guid>("empIDExecutor", ref fempIDExecutor, value); }
        }
    }

}
