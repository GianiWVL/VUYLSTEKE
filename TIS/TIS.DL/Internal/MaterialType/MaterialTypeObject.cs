using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using TIS.DL.Internal.MaterialCategory;
using PROF_IT.Common;
using System.Reflection;
using TIS.DL.Internal.MaterialSubType;
using TIS.DL.Internal.Revision;

namespace TIS.DL.Internal.MaterialType
{
    public class MaterialTypeObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaterialTypeObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "MaterialType";
        public const string MATTYP_ID = TABLE + "." + "mattypID";
        public const string MATCAT_ID = TABLE + "." + "matcatID";
        public const string TYPE = TABLE + "." + "Type";
        #endregion

        #region Fields

        private Guid _mattypID;
        private MaterialCategoryObject _materialCategory;
        private string _type = Constants.NullString;
        private Boolean _childsAdded = false;
        //Childs members
        private RevisionObjectCollection _revisions;
        private MaterialSubTypeObjectCollection _subTypes;

        private MaterialCategoryObject _loadedMaterialCategory;
        private string _loadedType = Constants.NullString;
        //Childs members
        private RevisionObjectCollection _loadedRevisions;
        private MaterialSubTypeObjectCollection _loadedSubTypes; 

        private MaterialTypeObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MatTypID
        {
            get { return _mattypID; }
            set { _mattypID = value; }
        }
        public MaterialCategoryObject MaterialCategory
        {
            get { return _materialCategory; }
            set { _materialCategory = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        //Childs members
        public RevisionObjectCollection Revisions
        {
            get { return _revisions; }
            set { _revisions = value; }
            
        }
        public MaterialSubTypeObjectCollection SubTypes
        {
            get { return _subTypes; }
            set { _subTypes = value; }
        }

        internal MaterialTypeObjectCollection Parent
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
        public MaterialTypeObject Clone()
        {
            return this.Clone<MaterialTypeObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MatTypID == ((MaterialTypeObject)obj).MatTypID)
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

        private void OnMaterialTypeObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaterialTypeObjectChanged(this);
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
                    _loadedType = Type;
                    //Child members
                    _loadedSubTypes = SubTypes;
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
                    MaterialCategory = _loadedMaterialCategory;
                    Type = _loadedType;
                    //Child members
                    Revisions = _loadedRevisions;
                    SubTypes = _loadedSubTypes;
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
                    _loadedType = Type;
                    //Child members
                    _loadedSubTypes = SubTypes;
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
