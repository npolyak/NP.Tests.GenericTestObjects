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
    public class PrintModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        PrintProp _homeCityPrintObj = null;
        public PrintProp HomeCityPrintObj
        {
            private get
            {
                return _homeCityPrintObj;
            }
            set
            {
                if (_homeCityPrintObj == value)
                    return;

                _homeCityPrintObj = value;

                OnPropertyChanged("HomeCityPrintObj");

            }
        }

        public PrintModel()
        {
            HomeCityPrintObj = new PrintProp("Home City");
        }

        public void Print()
        {
            HomeCityPrintObj.Print();
        }
    }
}
