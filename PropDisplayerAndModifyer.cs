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
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class PropDisplayerAndModifyer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public string PropName { get; private set; }

        public PropDisplayerAndModifyer(string propName)
        {
            PropName = propName;
        }


        #region PropValue Property
        private string _propValue;
        public string PropValue
        {
            get
            {
                return this._propValue;
            }
            set
            {
                if (this._propValue == value)
                {
                    return;
                }

                this._propValue = value;
                this.OnPropertyChanged("PropValue");
            }
        }
        #endregion PropValue Property


        public void Print()
        {
            Console.WriteLine(this.PropName + ": '" + PropValue + "'");
        }
    }
}
