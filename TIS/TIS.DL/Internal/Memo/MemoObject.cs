using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using TIS.DL.Internal.Material;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using System.Xml.Serialization;

namespace TIS.DL.Internal.Memo
{
    public class MemoObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MemoObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Memo";
        public const string MEMO_ID = TABLE + "." + "memoID";
        public const string MAT_ID = TABLE + "." + "matID";
        public const string DATETIME = TABLE + "." + "DateTime";
        public const string MEMO = TABLE + "." + "Memo";
        #endregion

        #region Fields

        private Guid _memoID;
        private MaterialObject _material;
        private DateTime _dateTime = Constants.NullDateTime;
        private string _memo = Constants.NullString;

        private MaterialObject _loadedMaterial;
        private DateTime _loadedDateTime = Constants.NullDateTime;
        private string _loadedMemo = Constants.NullString;

        private MemoObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MemoID
        {
            get { return _memoID; }
            set { _memoID = value; }
        }
        [XmlIgnore] public MaterialObject Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        internal MemoObjectCollection Parent
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
        public MemoObject Clone()
        {
            return this.Clone<MemoObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MemoID == ((MemoObject)obj).MemoID)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnMemoObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MemoObjectChanged(this);
                }
            }
            catch (Exception exception1)
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
                    _loadedMaterial = Material;
                    _loadedDateTime = DateTime;
                    _loadedMemo = Memo;
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
                    Material = _loadedMaterial;
                    DateTime = _loadedDateTime;
                    Memo = _loadedMemo;
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
                    _loadedMaterial = Material;
                    _loadedMemo = Memo;
                    _loadedDateTime = DateTime;
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
