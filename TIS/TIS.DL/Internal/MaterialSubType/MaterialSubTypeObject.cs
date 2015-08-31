using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.DL.Internal.MaterialType;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using TIS.DL.Internal.Revision;

namespace TIS.DL.Internal.MaterialSubType
{
    public class MaterialSubTypeObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaterialSubTypeObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "MaterialSubType";
        public const string MATSTYP_ID = TABLE + "." + "matstypID";
        public const string MATTYP_ID = TABLE + "." + "mattypID";
        public const string SUBTYPE = TABLE + "." + "SubType";
        #endregion

        #region Fields

        private Guid _matstypID;
        private MaterialTypeObject _materialType;
        private string _subType = Constants.NullString;
        private Boolean _childsAdded = false;
        //Child members
        private RevisionObjectCollection _revisions;

        private MaterialTypeObject _loadedMaterialType;
        private string _loadedSubType = Constants.NullString;
        //Child members
        private RevisionObjectCollection _loadedRevisions;

        private MaterialSubTypeObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MatStypID
        {
            get { return _matstypID; }
            set { _matstypID = value; }
        }
        public MaterialTypeObject MaterialType
        {
            get { return _materialType; }
            set { _materialType = value; }
        }
        public string SubType
        {
            get { return _subType; }
            set { _subType = value; }
        }
        //Child members
        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        public RevisionObjectCollection Revisions
        {
            get { return _revisions; }
            set { _revisions = value; }
        }

        internal MaterialSubTypeObjectCollection Parent
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
        public MaterialSubTypeObject Clone()
        {
            return this.Clone<MaterialSubTypeObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MatStypID == ((MaterialSubTypeObject)obj).MatStypID)
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

        private void OnMaterialSubTypeObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaterialSubTypeObjectChanged(this);
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
                    _loadedMaterialType = MaterialType;
                    _loadedSubType = SubType;
                    //Child members
                    _loadedRevisions = Revisions;
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
                    MaterialType = _loadedMaterialType;
                    SubType = _loadedSubType;
                    //Child members
                    Revisions = _loadedRevisions;
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
                    _loadedMaterialType = MaterialType;
                    _loadedSubType = SubType;
                    //Child members
                    _loadedRevisions = Revisions;
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
