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

    public partial class Schedule : XPCustomObject
    {
        Guid fschedID;
        [Key(true)]
        public Guid schedID
        {
            get { return fschedID; }
            set { SetPropertyValue<Guid>("schedID", ref fschedID, value); }
        }
        int fFrequency;
        public int Frequency
        {
            get { return fFrequency; }
            set { SetPropertyValue<int>("Frequency", ref fFrequency, value); }
        }
        bool fMonday;
        public bool Monday
        {
            get { return fMonday; }
            set { SetPropertyValue<bool>("Monday", ref fMonday, value); }
        }
        bool fTuesday;
        public bool Tuesday
        {
            get { return fTuesday; }
            set { SetPropertyValue<bool>("Tuesday", ref fTuesday, value); }
        }
        bool fWednesday;
        public bool Wednesday
        {
            get { return fWednesday; }
            set { SetPropertyValue<bool>("Wednesday", ref fWednesday, value); }
        }
        bool fThursday;
        public bool Thursday
        {
            get { return fThursday; }
            set { SetPropertyValue<bool>("Thursday", ref fThursday, value); }
        }
        bool fFriday;
        public bool Friday
        {
            get { return fFriday; }
            set { SetPropertyValue<bool>("Friday", ref fFriday, value); }
        }
        bool fSaterday;
        public bool Saterday
        {
            get { return fSaterday; }
            set { SetPropertyValue<bool>("Saterday", ref fSaterday, value); }
        }
        bool fSunday;
        public bool Sunday
        {
            get { return fSunday; }
            set { SetPropertyValue<bool>("Sunday", ref fSunday, value); }
        }
        string fStartdate;
        [Size(8)]
        public string Startdate
        {
            get { return fStartdate; }
            set { SetPropertyValue<string>("Startdate", ref fStartdate, value); }
        }
        string fTime;
        [Size(6)]
        public string Time
        {
            get { return fTime; }
            set { SetPropertyValue<string>("Time", ref fTime, value); }
        }
        string fLastSend;
        [Size(14)]
        public string LastSend
        {
            get { return fLastSend; }
            set { SetPropertyValue<string>("LastSend", ref fLastSend, value); }
        }
    }

}