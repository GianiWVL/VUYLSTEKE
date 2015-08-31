using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using PROF_IT.Common.Data;
using PROF_IT.Common;

namespace TIS.DL.Internal.Revision
{
    public class RevisionObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public RevisionObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Revision";
        public const string REV_ID = TABLE + "." + "revID";
        public const string MATCAT_ID = TABLE + "." + "matcatID";
        public const string MATTYP_ID = TABLE + "." + "mattypID";
        public const string MATSTYP_ID = TABLE + "." + "matstypID";
        public const string REVISION = TABLE + "." + "Revision";
        #endregion

        #region Fields

        private Guid _revID;
        private MaterialCategoryObject _materialCategory;
        private MaterialTypeObject _materialType;
        private MaterialSubTypeObject _materialSubType;
        private string _revision = Constants.NullString;

        private MaterialCategoryObject _loadedMaterialCategory;
        private MaterialTypeObject _loadedMaterialType;
        private MaterialSubTypeObject _loadedMaterialSubType;
        private string _loadedRevision = Constants.NullString;

        private RevisionObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid RevID
        {
            get { return _revID; }
            set { _revID = value; }
        }
        public MaterialCategoryObject MaterialCategory
        {
            get { return _materialCategory; }
            set { _materialCategory = value; }
        }
        public MaterialTypeObject MaterialType
        {
            get { return _materialType; }
            set { _materialType = value; }
        }
        public MaterialSubTypeObject MaterialSubType
        {
            get { return _materialSubType; }
            set { _materialSubType = value; }
        }
        public string Revision
        {
            get { return _revision; }
            set { _revision = value; }
        }

        internal RevisionObjectCollection Parent
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
        public RevisionObject Clone()
        {
            return this.Clone<RevisionObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.RevID == ((RevisionObject)obj).RevID)
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

        private void OnRevisionObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.RevisionObjectChanged(this);
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
                    _loadedMaterialCategory = MaterialCategory;
                    _loadedMaterialType = MaterialType;
                    _loadedMaterialSubType = MaterialSubType;
                    _loadedRevision = Revision;
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
                    MaterialCategory = _loadedMaterialCategory;
                    MaterialType = _loadedMaterialType;
                    MaterialSubType = _loadedMaterialSubType;
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
                    _loadedMaterialCategory = MaterialCategory;
                    _loadedMaterialType = MaterialType;
                    _loadedMaterialSubType = MaterialSubType;
                    _loadedRevision = Revision;
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
