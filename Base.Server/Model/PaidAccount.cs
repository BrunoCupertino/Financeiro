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
    public partial class PaidAccount
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Discount
        {
            get;
            set;
        }
    
        public virtual Nullable<double> InterestRate
        {
            get;
            set;
        }
    
        public virtual Nullable<double> Fine
        {
            get;
            set;
        }
    
        public virtual decimal Rating
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

        #endregion
        #region Association Fixup
    
        private void FixupAccountsPayable(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (AccountsPayable item in e.NewItems)
                {
                    item.PaidAccount = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (AccountsPayable item in e.OldItems)
                {
                    if (ReferenceEquals(item.PaidAccount, this))
                    {
                        item.PaidAccount = null;
                    }
                }
            }
        }

        #endregion
    }
}
