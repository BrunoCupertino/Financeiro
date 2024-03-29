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
    [EntitySetNameAttribute(EntitySetName = "User")]
    public partial class User
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual string FirstName
        {
            get;
            set;
        }
    
        public virtual string LastName
        {
            get;
            set;
        }
    
        public virtual string Password
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual int State
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<AccountsPayable> AccountsPayable
        {
            get
            {
                if (_accountsPayable == null)
                {
                    var newCollection = new FixupCollection<AccountsPayable>();
                    newCollection.CollectionChanged += FixupAccountsPayable;
                    _accountsPayable = newCollection;
                }
                return _accountsPayable;
            }
            set
            {
                if (!ReferenceEquals(_accountsPayable, value))
                {
                    var previousValue = _accountsPayable as FixupCollection<AccountsPayable>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAccountsPayable;
                    }
                    _accountsPayable = value;
                    var newValue = value as FixupCollection<AccountsPayable>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAccountsPayable;
                    }
                }
            }
        }
        private ICollection<AccountsPayable> _accountsPayable;
    
        public virtual ICollection<Provider> Provider
        {
            get
            {
                if (_provider == null)
                {
                    var newCollection = new FixupCollection<Provider>();
                    newCollection.CollectionChanged += FixupProvider;
                    _provider = newCollection;
                }
                return _provider;
            }
            set
            {
                if (!ReferenceEquals(_provider, value))
                {
                    var previousValue = _provider as FixupCollection<Provider>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupProvider;
                    }
                    _provider = value;
                    var newValue = value as FixupCollection<Provider>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupProvider;
                    }
                }
            }
        }
        private ICollection<Provider> _provider;

        #endregion
        #region Association Fixup
    
        private void FixupAccountsPayable(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (AccountsPayable item in e.NewItems)
                {
                    item.User = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (AccountsPayable item in e.OldItems)
                {
                    if (ReferenceEquals(item.User, this))
                    {
                        item.User = null;
                    }
                }
            }
        }
    
        private void FixupProvider(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Provider item in e.NewItems)
                {
                    item.User = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Provider item in e.OldItems)
                {
                    if (ReferenceEquals(item.User, this))
                    {
                        item.User = null;
                    }
                }
            }
        }

        #endregion
    }
}
