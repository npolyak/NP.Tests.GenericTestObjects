using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class Org : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region TheContacts Property
        private ObservableCollection<ContactWithAddressCollection> _contacts;
        public ObservableCollection<ContactWithAddressCollection> TheContacts
        {
            get
            {
                return this._contacts;
            }
            set
            {
                if (this._contacts == value)
                {
                    return;
                }

                this._contacts = value;
                this.OnPropertyChanged(nameof(TheContacts));
            }
        }
        #endregion TheContacts Property



        #region OrgName Property
        private string _orgName = null;
        public string OrgName
        {
            get
            {
                return this._orgName;
            }
            set
            {
                if (this._orgName == value)
                {
                    return;
                }

                this._orgName = value;
                this.OnPropertyChanged(nameof(OrgName));
            }
        }
        #endregion OrgName Property

    }


    public static class OrgBuilder
    {
        public static Org Build()
        {

            // build the data tree
            Address addr1 = new Address();
            addr1.City = "Miami";
            addr1.Street = "Sterling Rd";


            Address addr2 = new Address();
            addr2.City = "Boston";
            addr2.Street = "Blenford Rd";

            ContactWithAddressCollection nickContact =
                new ContactWithAddressCollection()
                {
                    FirstName = "Nick",
                    LastName = "Polyak",
                    TheAddresses = new ObservableCollection<Address>(),
                    ThePrimaryAddress = addr1
                };

            nickContact.TheAddresses.Add(addr1);
            nickContact.TheAddresses.Add(addr2);

            ContactWithAddressCollection joeContact = new ContactWithAddressCollection
            {
                FirstName = "Joe",
                LastName = "Doe",
                TheAddresses = new ObservableCollection<Address>()
            };

            joeContact.TheAddresses.Add
            (
                new Address
                {
                    City = "Chicago"
                }
            );

            // 'org' is the root of the data tree
            Org org = new Org
            {
                OrgName = "A union of Underpaid Software Developers"
            };

            org.TheContacts = new ObservableCollection<ContactWithAddressCollection>();
            org.TheContacts.Add(nickContact);
            org.TheContacts.Add(joeContact);

            return org;
        }
    }
}
