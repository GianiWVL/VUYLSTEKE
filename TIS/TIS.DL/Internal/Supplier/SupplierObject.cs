using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.Supplier
{

    public class SupplierObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public SupplierObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Supplier";
        public const string SUP_ID = TABLE + "." + "supID";
        public const string TRANSC_ID = TABLE + "." + "transcID";
        public const string TAS_ID = TABLE + "." + "tasID";
        public const string NAME = TABLE + "." + "Name";
        public const string NAME2 = TABLE + "." + "Name2";
        public const string STREET = TABLE + "." + "Street";
        public const string HOUSE_NUMBER = TABLE + "." + "HouseNumber";
        public const string ZIPCODE = TABLE + "." + "Zipcode";
        public const string TOWN = TABLE + "." + "Town";
        public const string COUNTRY = TABLE + "." + "Country";
        public const string VAT = TABLE + "." + "VAT";
        public const string PHONE = TABLE + "." + "Phone";
        public const string LANGUAGE = TABLE + "." + "Language";
        public const string CURRENCY = TABLE + "." + "Currency";
        public const string EMAIL = TABLE + "." + "Email";
        #endregion

        #region Fields

        private Guid _supID;
        private int _transcID = Constants.NullInt;
        private int _tasID = Constants.NullInt;
        private string _name = Constants.NullString;
        private string _name2 = Constants.NullString;
        private string _street = Constants.NullString;
        private string _houseNumber = Constants.NullString;
        private string _zipCode = Constants.NullString;
        private string _town = Constants.NullString;
        private string _country = Constants.NullString;
        private string _vat = Constants.NullString;
        private string _phone = Constants.NullString;
        private string _language = Constants.NullString;
        private string _currency = Constants.NullString;
        private string _email = Constants.NullString;

        private int _loadedTranscID = Constants.NullInt;
        private int _loadedTasID = Constants.NullInt;
        private string _loadedName = Constants.NullString;
        private string _loadedName2 = Constants.NullString;
        private string _loadedStreet = Constants.NullString;
        private string _loadedHouseNumber = Constants.NullString;
        private string _loadedZipCode = Constants.NullString;
        private string _loadedTown = Constants.NullString;
        private string _loadedCountry = Constants.NullString;
        private string _loadedVat = Constants.NullString;
        private string _loadedPhone = Constants.NullString;
        private string _loadedLanguage = Constants.NullString;
        private string _loadedCurrency = Constants.NullString;
        private string _loadedEmail = Constants.NullString;

        private SupplierObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid SupID
        {
            get { return _supID; }
            set { _supID = value; }
        }

        public int TranscID
        {
            get { return _transcID; }
            set { _transcID = value; }
        }

        public int TasID
        {
            get { return _tasID; }
            set { _tasID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }

        public string Zipcode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public string Town
        {
            get { return _town; }
            set { _town = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string Vat
        {
            get { return _vat; }
            set { _vat = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        internal SupplierObjectCollection Parent
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
        public SupplierObject Clone()
        {
            return this.Clone<SupplierObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.SupID == ((SupplierObject)obj).SupID)
                    return true;
                else
                    return false;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnSupplierObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.SupplierObjectChanged(this);
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
                if (!inTxn)
                {
                    _loadedTranscID = this.TranscID;
                    _loadedTasID = this.TasID;
                    _loadedName = this.Name;
                    _loadedName2 = this.Name2;
                    _loadedStreet = this.Street;
                    _loadedHouseNumber = this.HouseNumber;
                    _loadedZipCode = this.Zipcode;
                    _loadedTown = this.Town;
                    _loadedCountry = this.Country;
                    _loadedVat = this.Vat;
                    _loadedPhone = this.Phone;
                    _loadedLanguage = this.Language;
                    _loadedCurrency = this.Currency;
                    _loadedEmail = this.Email;
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
                    this.TranscID = _loadedTranscID;
                    this.TasID = _loadedTasID;
                    this.Name = _loadedName;
                    this.Name2 = _loadedName2;
                    this.Street = _loadedStreet;
                    this.HouseNumber = _loadedHouseNumber;
                    this.Zipcode = _loadedZipCode;
                    this.Town = _loadedTown;
                    this.Country = _loadedCountry;
                    this.Vat = _loadedVat;
                    this.Phone = _loadedPhone;
                    this.Language = _loadedLanguage;
                    this.Currency = _loadedCurrency;
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
                    _loadedTranscID = this.TranscID;
                    _loadedTasID = this.TasID;
                    _loadedName = this.Name;
                    _loadedName2 = this.Name2;
                    _loadedStreet = this.Street;
                    _loadedHouseNumber = this.HouseNumber;
                    _loadedZipCode = this.Zipcode;
                    _loadedTown = this.Town;
                    _loadedCountry = this.Country;
                    _loadedVat = this.Vat;
                    _loadedPhone = this.Phone;
                    _loadedLanguage = this.Language;
                    _loadedCurrency = this.Currency;
                    _loadedEmail = this.Email;
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
