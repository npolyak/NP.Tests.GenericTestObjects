using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class ObjectContainer : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region TheObj Property
        private object _obj;
        public object TheObj
        {
            get
            {
                return this._obj;
            }
            set
            {
                if (this._obj == value)
                {
                    return;
                }

                this._obj = value;
                this.OnPropertyChanged(nameof(TheObj));
            }
        }
        #endregion TheObj Property
    }
}
