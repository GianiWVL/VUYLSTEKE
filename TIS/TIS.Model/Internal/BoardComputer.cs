using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TIS.Model.Internal
{
    public partial class BoardComputer : XPCustomObject
    {
        public BoardComputer(Session session) : base(session) { }
        public BoardComputer() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        Int64 fID;
        [Key(true)]
        public Int64 Id
        {
            get { return fID; }
            set { SetPropertyValue<Int64>("Id", ref fID, value); }
        }
        string fBrand;
        public string Brand
        {
            get { return fBrand; }
            set { SetPropertyValue<string>("Brand", ref fBrand, value); }
        }
        string fSerialNumber;
        public string SerialNumber
        {
            get { return fSerialNumber; }
            set { SetPropertyValue<string>("SerialNumber", ref fSerialNumber, value); }
        }
        Supplier fSupplier;
        [Association(@"BoardComputer.tasID_Supplier")]
        public Supplier Supplier
        { 
            get { return fSupplier; }
            set { SetPropertyValue<Supplier>("Supplier", ref fSupplier, value); }
        }
        Vehicle fVehicleBuildIn;
        [Association(@"BoardComputer.vehID_Vehicle")]
        public Vehicle VehicleBuildIn
        {
            get { return fVehicleBuildIn; }
            set { SetPropertyValue<Vehicle>("VehicleBuildIn", ref fVehicleBuildIn, value); }
        }
        DateTime fDateBuildIn;
        public DateTime DateBuildIn
        {
            get { return fDateBuildIn; }
            set { SetPropertyValue<DateTime>("DateBuildIn", ref fDateBuildIn, value); }
        }

        public void Add(BoardComputer bc)
        {
            try
            {
                Session.Save(bc);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public XPCollection<BoardComputer> GetAll()
        {
            try
            {
                XPCollection<BoardComputer> boardcomputers = new XPCollection<BoardComputer>(Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Ascending));
                boardcomputers.Sorting = sc;
                return boardcomputers;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
    }
}
