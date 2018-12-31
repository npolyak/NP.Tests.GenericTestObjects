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
        private Address _homeAddress;
        public Address HomeAddress
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

                this.OnPropertyChanged(nameof(HomeAddress));
            }
        }
        #endregion HomeAddress Property

        #region WorkAddress Property
        private Address _workAddress;
        public Address WorkAddress
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

                this.OnPropertyChanged(nameof(HomeAddress));
            }
        }
        #endregion WorkAddress Property
    }
}
