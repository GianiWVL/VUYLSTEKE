﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Reflection;

namespace TIS.DL.Internal.VehicleType
{
    public class VehicleTypeObjectCollection : CollectionBase, IBindingList
    {
        #region Fields

        private ListChangedEventArgs _resetEvent = new ListChangedEventArgs(ListChangedType.Reset, -1);
        private ListChangedEventHandler _onListChanged;

        #endregion

        #region Constructor

        public VehicleTypeObjectCollection()
        {
        }

        #endregion

        #region Properties

        public VehicleTypeObject this[int index]
        {
            get
            {
                return (VehicleTypeObject)(List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        #endregion

        #region Methods

        public int Add(VehicleTypeObject value)
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

        public VehicleTypeObject AddNew()
        {
            try
            {
                return (VehicleTypeObject)((IBindingList)this).AddNew();
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(VehicleTypeObject value)
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

        // Called by VehicleTypeObject when it changes
        internal void VehicleTypeObjectChanged(VehicleTypeObject VehicleType)
        {
            try
            {
                int index = List.IndexOf(VehicleType);
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
                foreach (VehicleTypeObject VehicleType in List)
                {
                    VehicleType.Parent = null;
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
                VehicleTypeObject VehicleType = (VehicleTypeObject)value;
                VehicleType.Parent = this;
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
                VehicleTypeObject VehicleType = (VehicleTypeObject)value;
                VehicleType.Parent = this;
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
                    VehicleTypeObject oldVehicleType = (VehicleTypeObject)oldValue;
                    VehicleTypeObject newVehicleType = (VehicleTypeObject)newValue;
                    oldVehicleType.Parent = null;
                    newVehicleType.Parent = this;

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
                VehicleTypeObject VehicleType = new VehicleTypeObject();
                List.Add(VehicleType);
                return VehicleType;
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
