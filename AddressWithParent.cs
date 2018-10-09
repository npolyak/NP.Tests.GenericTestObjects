using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    public class AddressWithParent : Address
    {
        public object TheParent { get; set; }
    }
}
