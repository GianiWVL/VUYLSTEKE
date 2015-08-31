using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.DL.Internal.Maintenance;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.MaterialRevision
{
    public class MaterialRevisionObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaterialRevisionObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "MaterialRevision";
        public const string MATREV_ID = TABLE + "." + "matrevID";
        public const string MAINT_ID = TABLE + "." + "maintID";
        public const string REVISION = TABLE + "." + "Revision";
        public const string ANSWER = TABLE + "." + "Answer";
        public const string CATEGORY = TABLE + "." + "Category";
        #endregion

        #region Fields

        private Guid _matrevID;
        private MaintenanceObject _maintenance;
        private string _revision = Constants.NullString;
        private string _answer = Constants.NullString;
        private string _category = Constants.NullString;

        private MaintenanceObject _loadedMaintenance;
        private string _loadedRevision = Constants.NullString;
        private string _loadedAnswer = Constants.NullString;
        private string _loadedCategory = Constants.NullString;

        private MaterialRevisionObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MatRevID
        {
            get { return _matrevID; }
            set { _matrevID = value; }
        }
        public MaintenanceObject Maintenance
        {
            get { return _maintenance; }
            set { _maintenance = value; }
        }
        public string Revision
        {
            get { return _revision; }
            set { _revision = value; }
        }
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        internal MaterialRevisionObjectCollection Parent
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
        public MaterialRevisionObject Clone()
        {
            return this.Clone<MaterialRevisionObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MatRevID == ((MaterialRevisionObject)obj).MatRevID)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnMaterialRevisionObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaterialRevisionObjectChanged(this);
                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion

        #region IEditableObject

        void IEditableObject.BeginEdit()
        {
            try
            {
                if (!_inTxn)
                {
                    _loadedAnswer = Answer;
                    _loadedMaintenance = Maintenance;
                    _loadedRevision  = Revision;
                    _loadedCategory = Category;
                    _inTxn = true;
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
                if (_inTxn)
                {
                    Answer = _loadedAnswer;
                    Maintenance = _loadedMaintenance;
                    Revision = _loadedRevision;
                    Category = _loadedCategory;
                    _inTxn = false;
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
                if (_inTxn)
                {
                    _loadedAnswer = Answer;
                    _loadedMaintenance = Maintenance;
                    _loadedRevision = Revision;
                    _loadedCategory = Category;
                    _inTxn = true;
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
