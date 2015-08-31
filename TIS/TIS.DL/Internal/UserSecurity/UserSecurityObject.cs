using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityObject : IEditableObject
    {
        #region Constructor
        public UserSecurityObject()
        {

        }
        #endregion

        #region Fields
        private UserSecurityApplication _application = new UserSecurityApplication();
        private UserSecurityMain _main = new UserSecurityMain();
        private UserSecurityCosting _costing = new UserSecurityCosting();
        private UserSecurityVehicle _vehicle = new UserSecurityVehicle();
        private UserSecurityMaterial _material = new UserSecurityMaterial();
        private UserSecurityPlanning _planning = new UserSecurityPlanning();

        private UserSecurityApplication _loadedApplication = new UserSecurityApplication();
        private UserSecurityMain _loadedMain = new UserSecurityMain();
        private UserSecurityCosting _loadedCosting = new UserSecurityCosting();
        private UserSecurityVehicle _loadedVehicle = new UserSecurityVehicle();
        private UserSecurityMaterial _loadedMaterial = new UserSecurityMaterial();
        private UserSecurityPlanning _loadedPlanning = new UserSecurityPlanning();

        private UserSecurityObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public UserSecurityApplication Application
        {
            get { return _application; }
            set { _application = value; }
        }

        public UserSecurityMain Main
        {
            get { return _main; }
            set { _main = value; }
        }

        public UserSecurityCosting Costing
        {
            get { return _costing; }
            set { _costing = value; }
        }

        public UserSecurityVehicle Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }

        public UserSecurityMaterial Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public UserSecurityPlanning Planning
        {
            get { return _planning; }
            set { _planning = value; }
        }


        internal UserSecurityObjectCollection Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        public Enumerations.ObjectState State
        {
            get { return _state; }
            set { _state = value; }
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            //if (this.UsrID == ((UserSecurityObject)obj).UsrID)
            //    return true;
            //else
            //    return false;
            return true;
        }

        private void OnUserObjectChanged()
        {
            if (inTxn && Parent != null)
            {
                Parent.UserSecurityObjectChanged(this);
            }
        }

        #endregion

        #region IEditableObject

        void IEditableObject.BeginEdit()
        {
            try
            {
                if (!inTxn)
                {
                    _loadedApplication = this.Application;
                    _loadedMain = this.Main;
                    _loadedCosting = this.Costing;
                    _loadedVehicle = this.Vehicle;
                    _loadedMaterial = this.Material;
                    _loadedPlanning = this.Planning;
                    inTxn = true;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        void IEditableObject.CancelEdit()
        {
            try
            {
                if (inTxn)
                {
                    this.Application = _loadedApplication;
                    this.Main = _loadedMain;
                    this.Costing = _loadedCosting;
                    this.Vehicle = _loadedVehicle;
                    this.Material = _loadedMaterial;
                    this.Planning = _loadedPlanning;
                    inTxn = false;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        void IEditableObject.EndEdit()
        {
            try
            {
                if (inTxn)
                {
                    _loadedApplication = this.Application;
                    _loadedMain = this.Main;
                    _loadedCosting = this.Costing;
                    _loadedVehicle = this.Vehicle;
                    _loadedMaterial = this.Material;
                    _loadedPlanning = this.Planning;
                    inTxn = false;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion
    }
}
