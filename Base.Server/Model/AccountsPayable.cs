//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Base.Server.Model
{
    public partial class AccountsPayable
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual System.DateTime ExpirationDate
        {
            get;
            set;
        }
    
        public virtual int ProviderId
        {
            get { return _providerId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_providerId != value)
                    {
                        if (Provider != null && Provider.Id != value)
                        {
                            Provider = null;
                        }
                        _providerId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private int _providerId;
    
        public virtual decimal Rating
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual Nullable<int> PaidAccountId
        {
            get { return _paidAccountId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_paidAccountId != value)
                    {
                        if (PaidAccount != null && PaidAccount.Id != value)
                        {
                            PaidAccount = null;
                        }
                        _paidAccountId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _paidAccountId;
    
        public virtual int UserId
        {
            get { return _userId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_userId != value)
                    {
                        if (User != null && User.Id != value)
                        {
                            User = null;
                        }
                        _userId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private int _userId;

        #endregion
        #region Navigation Properties
    
        public virtual PaidAccount PaidAccount
        {
            get { return _paidAccount; }
            set
            {
                if (!ReferenceEquals(_paidAccount, value))
                {
                    var previousValue = _paidAccount;
                    _paidAccount = value;
                    FixupPaidAccount(previousValue);
                }
            }
        }
        private PaidAccount _paidAccount;
    
        public virtual Provider Provider
        {
            get { return _provider; }
            set
            {
                if (!ReferenceEquals(_provider, value))
                {
                    var previousValue = _provider;
                    _provider = value;
                    FixupProvider(previousValue);
                }
            }
        }
        private Provider _provider;
    
        public virtual User User
        {
            get { return _user; }
            set
            {
                if (!ReferenceEquals(_user, value))
                {
                    var previousValue = _user;
                    _user = value;
                    FixupUser(previousValue);
                }
            }
        }
        private User _user;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupPaidAccount(PaidAccount previousValue)
        {
            if (previousValue != null && previousValue.AccountsPayable.Contains(this))
            {
                previousValue.AccountsPayable.Remove(this);
            }
    
            if (PaidAccount != null)
            {
                if (!PaidAccount.AccountsPayable.Contains(this))
                {
                    PaidAccount.AccountsPayable.Add(this);
                }
                if (PaidAccountId != PaidAccount.Id)
                {
                    PaidAccountId = PaidAccount.Id;
                }
            }
            else if (!_settingFK)
            {
                PaidAccountId = null;
            }
        }
    
        private void FixupProvider(Provider previousValue)
        {
            if (previousValue != null && previousValue.AccountsPayable.Contains(this))
            {
                previousValue.AccountsPayable.Remove(this);
            }
    
            if (Provider != null)
            {
                if (!Provider.AccountsPayable.Contains(this))
                {
                    Provider.AccountsPayable.Add(this);
                }
                if (ProviderId != Provider.Id)
                {
                    ProviderId = Provider.Id;
                }
            }
        }
    
        private void FixupUser(User previousValue)
        {
            if (previousValue != null && previousValue.AccountsPayable.Contains(this))
            {
                previousValue.AccountsPayable.Remove(this);
            }
    
            if (User != null)
            {
                if (!User.AccountsPayable.Contains(this))
                {
                    User.AccountsPayable.Add(this);
                }
                if (UserId != User.Id)
                {
                    UserId = User.Id;
                }
            }
        }

        #endregion
    }
}