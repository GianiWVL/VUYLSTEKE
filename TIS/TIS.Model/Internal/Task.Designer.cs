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

    public partial class Task : XPCustomObject
    {
        Guid ftaskID;
        [Key(true)]
        public Guid taskID
        {
            get { return ftaskID; }
            set { SetPropertyValue<Guid>("taskID", ref ftaskID, value); }
        }
        string fTag;
        [Size(SizeAttribute.Unlimited)]
        public string Tag
        {
            get { return fTag; }
            set { SetPropertyValue<string>("Tag", ref fTag, value); }
        }
        string fCreationDate;
        [Size(14)]
        public string CreationDate
        {
            get { return fCreationDate; }
            set { SetPropertyValue<string>("CreationDate", ref fCreationDate, value); }
        }
        string fUpdateDate;
        [Size(14)]
        public string UpdateDate
        {
            get { return fUpdateDate; }
            set { SetPropertyValue<string>("UpdateDate", ref fUpdateDate, value); }
        }
        string fDueDate;
        [Size(14)]
        public string DueDate
        {
            get { return fDueDate; }
            set { SetPropertyValue<string>("DueDate", ref fDueDate, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        int fStatus;
        public int Status
        {
            get { return fStatus; }
            set { SetPropertyValue<int>("Status", ref fStatus, value); }
        }
        int fPriority;
        public int Priority
        {
            get { return fPriority; }
            set { SetPropertyValue<int>("Priority", ref fPriority, value); }
        }
        int fEffort;
        public int Effort
        {
            get { return fEffort; }
            set { SetPropertyValue<int>("Effort", ref fEffort, value); }
        }
    }

}
