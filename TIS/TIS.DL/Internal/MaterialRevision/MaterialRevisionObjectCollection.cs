using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace TIS.DL.Internal.MaterialRevision
{
    public class MaterialRevisionObjectCollection : CollectionBase, IBindingList
    {
        #region Fields

        private ListChangedEventArgs _resetEvent = new ListChangedEventArgs(ListChangedType.Reset, -1);
        private ListChangedEventHandler _onListChanged;

        #endregion

        #region Constructor

        public MaterialRevisionObjectCollection()
        {
        }

        #endregion

        #region Properties

        public MaterialRevisionObject this[int index]
        {
            get
            {
                return (MaterialRevisionObject)(List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        #endregion

        #region Methods

        public int Add(MaterialRevisionObject value)
        {
            try
            {
                return List.Add(value);
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaterialRevisionObject AddNew()
        {
            try
            {
                return (MaterialRevisionObject)((IBindingList)this).AddNew();
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(MaterialRevisionObject value)
        {
            try
            {
                List.Remove(value);
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        protected virtual void OnListChanged(ListChangedEventArgs ev)
        {
            try
            {
                if (_onListChanged != null)
                {
                    _onListChanged(this, ev);

                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        // Called by MaterialRevisionObject when it changes
        internal void MaterialRevisionObjectChanged(MaterialRevisionObject MaterialRevision)
        {
            try
            {
                int index = List.IndexOf(MaterialRevision);
                OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion

        #region IBindingList

        // Methods
        protected override void OnClear()
        {
            try
            {
                foreach (MaterialRevisionObject MaterialRevision in List)
                {
                    MaterialRevision.Parent = null;
                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        protected override void OnClearComplete()
        {
            try
            {
                OnListChanged(_resetEvent);
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        protected override void OnInsertComplete(int index, object value)
        {
            try
            {
                MaterialRevisionObject MaterialRevision = (MaterialRevisionObject)value;
                MaterialRevision.Parent = this;
                OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        protected override void OnRemoveComplete(int index, object value)
        {
            try
            {
                MaterialRevisionObject MaterialRevision = (MaterialRevisionObject)value;
                MaterialRevision.Parent = this;
                OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        protected override void OnSetComplete(int index, object oldValue, object newValue)
        {
            try
            {
                if (oldValue != newValue)
                {
                    MaterialRevisionObject oldMaterialRevision = (MaterialRevisionObject)oldValue;
                    MaterialRevisionObject newMaterialRevision = (MaterialRevisionObject)newValue;
                    oldMaterialRevision.Parent = null;
                    newMaterialRevision.Parent = this;

                    OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        // Events
        public event ListChangedEventHandler ListChanged
        {
            add
            {
                _onListChanged += value;
            }
            remove
            {
                _onListChanged -= value;
            }
        }

        // Methods.
        object IBindingList.AddNew()
        {
            try
            {
                MaterialRevisionObject MaterialRevision = new MaterialRevisionObject();
                List.Add(MaterialRevision);
                return MaterialRevision;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        // Implements IBindinglist
        bool IBindingList.AllowEdit
        {
            get { return true; }
        }

        bool IBindingList.AllowNew
        {
            get { return true; }
        }

        bool IBindingList.AllowRemove
        {
            get { return true; }
        }

        bool IBindingList.SupportsChangeNotification
        {
            get { return true; }
        }

        bool IBindingList.SupportsSearching
        {
            get { return false; }
        }

        bool IBindingList.SupportsSorting
        {
            get { return false; }
        }

        // Unsupported properties.
        bool IBindingList.IsSorted
        {
            get { throw new NotSupportedException(); }
        }

        ListSortDirection IBindingList.SortDirection
        {
            get { throw new NotSupportedException(); }
        }

        PropertyDescriptor IBindingList.SortProperty
        {
            get { throw new NotSupportedException(); }
        }

        // Unsupported Methods.
        void IBindingList.AddIndex(PropertyDescriptor property)
        {
            throw new NotSupportedException();
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotSupportedException();
        }

        int IBindingList.Find(PropertyDescriptor property, object key)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveSort()
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}
