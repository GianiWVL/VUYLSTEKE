using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.ComponentModel;
using PROF_IT.Common;
using System.Reflection;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.Revision;

namespace TIS.DL.Internal.MaterialCategory
{
    public class MaterialCategoryObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaterialCategoryObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "MaterialCategory";
        public const string MATCAT_ID = TABLE + "." + "matcatID";
        public const string CATEGORY = TABLE + "." + "Category";
        #endregion

        #region Fields

        private Guid _matcatID;
        private string _category = Constants.NullString;
        //Child Members
        private MaterialTypeObjectCollection _types;
        private RevisionObjectCollection _revisions;
        private Boolean _childsAdded = false;

        private string _loadedCategory = Constants.NullString;
        //Child Members
        private RevisionObjectCollection _loadedRevisions;
        private MaterialTypeObjectCollection _loadedTypes;

        private MaterialCategoryObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MatcatID
        {
            get { return _matcatID; }
            set { _matcatID = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        //Child Members
        public RevisionObjectCollection Revisions
        {
            get { return _revisions; }
            set { _revisions = value; }
        }
        public MaterialTypeObjectCollection Types
        {
            get { return _types; }
            set { _types = value; }
        }

        internal MaterialCategoryObjectCollection Parent
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
        public MaterialCategoryObject Clone()
        {
            return this.Clone<MaterialCategoryObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MatcatID == ((MaterialCategoryObject)obj).MatcatID)
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

        private void OnMaterialCategoryObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaterialCategoryObjectChanged(this);
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
                    _loadedCategory = Category;
                    //Child Members
                    _loadedTypes = Types;
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
                    Category = _category;
                    //Child members
                    Types = _loadedTypes;
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
                    _loadedCategory = Category;
                    //Child members
                    _loadedTypes = Types;
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
