using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    sealed class MiniVan:Car
    {
        public MiniVan()
        {
            
        }
    }
    //Cannot derive from sealed type
    //class MyString : String { }
}
