using NP.Tests.GenericTestObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class ContactWithCity : Contact
    {

        #region TheCity Property
        private string _city;
        public string TheCity
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
                this.OnPropertyChanged(nameof(TheCity));
            }
        }
        #endregion TheCity Property
    }
}
