using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class ContactWithAddressCollection : Person, INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanging(string propertyName)
        {
            this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }


        public event PropertyChangingEventHandler PropertyChanging;
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region ThePrimaryAddress Property
        private Address _primaryAddress;
        public Address ThePrimaryAddress
        {
            get
            {
                return this._primaryAddress;
            }
            set
            {
                if (this._primaryAddress == value)
                {
                    return;
                }

                this._primaryAddress = value;
                this.OnPropertyChanged(nameof(ThePrimaryAddress));
            }
        }
        #endregion ThePrimaryAddress Property


        #region TheAddresses Property
        private ObservableCollection<Address> _addresses = null;
        public ObservableCollection<Address> TheAddresses
        {
            get
            {
                return this._addresses;
            }
            set
            {
                if (this._addresses == value)
                {
                    return;
                }

                this.OnPropertyChanging(nameof(TheAddresses));
                this._addresses = value;
                this.OnPropertyChanged(nameof(TheAddresses));
            }
        }
        #endregion TheAddresses Property


        #region TheCities Property
        private List<ObjectContainer> _cities = null;
        public List<ObjectContainer> TheCities
        {
            get
            {
                return this._cities;
            }
            set
            {
                if (this._cities == value)
                {
                    return;
                }

                this._cities = value;
                this.OnPropertyChanged(nameof(TheCities));
            }
        }
        #endregion TheCities Property

    }
}
