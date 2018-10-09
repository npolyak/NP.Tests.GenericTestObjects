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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class PrintProp
    {
        public PrintProp(string propName)
        {
            _propName = propName;
        }

        readonly string _propName;
        public object PropValueToPrint { get; set; } 

        public void Print()
        {
            string strToPrint = "null";

            if (PropValueToPrint != null)
                strToPrint = PropValueToPrint.ToString();

            Console.WriteLine(_propName + ": " + strToPrint);
        }
    }
}
