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

    public partial class VehicleTransicsLink : XPCustomObject
    {
        int fvehtiID;
        [Key(true)]
        public int vehtiID
        {
            get { return fvehtiID; }
            set { SetPropertyValue<int>("vehtiID", ref fvehtiID, value); }
        }
        int ftransc_VehicleID;
        public int transc_VehicleID
        {
            get { return ftransc_VehicleID; }
            set { SetPropertyValue<int>("transc_VehicleID", ref ftransc_VehicleID, value); }
        }
        int ftransi_TNR_mat;
        public int transi_TNR_mat
        {
            get { return ftransi_TNR_mat; }
            set { SetPropertyValue<int>("transi_TNR_mat", ref ftransi_TNR_mat, value); }
        }
    }

}
