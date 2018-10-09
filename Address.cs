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

using System;
using System.ComponentModel;

namespace NP.Tests.GenericTestObjects
{
    public class Address : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        #region City Property
        private string _city;
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                if (this._city == value)
                {
                    return;
                }

                this._city = value;
                this.OnPropertyChanged("City");
            }
        }
        #endregion City Property


        #region Street Property
        private string _street;
        public string Street
        {
            get
            {
                return this._street;
            }
            set
            {
                if (this._street == value)
                {
                    return;
                }

                this._street = value;
                this.OnPropertyChanged(nameof(Street));
            }
        }
        #endregion Street Property
    }
}
