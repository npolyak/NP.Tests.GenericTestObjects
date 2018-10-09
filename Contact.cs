// (c) Nick Polyak 2015 - http://awebpros.com/
// License: Code Project Open License (CPOL) 1.92(http://www.codeproject.com/info/cpol10.aspx)
//
// short overview of copyright rules:
// 1. you can use this framework in any commercial or non-commercial 
//    product as long as you retain this copyright message
// 2. Do not blame the author(s) of this software if something goes wrong. 
// 
// Also as a courtesy, please, mention this software in any documentation for the 
// products that use it.

using NP.Tests.GenericTestObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NP.Tests.GenericTestObjects
{
    public class Contact : Person, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        #region HomeAddress Property
        private AddressWithParent _homeAddress;
        public AddressWithParent HomeAddress
        {
            get
            {
                return this._homeAddress;
            }
            set
            {
                if (this._homeAddress == value)
                {
                    return;
                }

                this._homeAddress = value;

                if (_homeAddress != null)
                {
                    // in most tests "TheParent" property is not needed
                    _homeAddress.TheParent = this;
                }
                this.OnPropertyChanged(nameof(HomeAddress));
            }
        }
        #endregion HomeAddress Property


        #region WorkAddress Property
        private AddressWithParent _workAddress;
        public AddressWithParent WorkAddress
        {
            get
            {
                return this._workAddress;
            }
            set
            {
                if (this._workAddress == value)
                {
                    return;
                }

                this._workAddress = value;

                if (_workAddress != null)
                {                   
                    // in most tests "TheParent" property is not needed
                    _workAddress.TheParent = this;
                }
                this.OnPropertyChanged(nameof(HomeAddress));
            }
        }
        #endregion WorkAddress Property
    }
}
