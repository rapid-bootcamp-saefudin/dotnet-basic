using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    public class SampleInheritance
    {
        public class A
        {
            private int _value = 10;

            public class B : A
            {
                public int GetValue()
                {
                    return _value;
                }
            }
        }

        public class C : A
        {
            //    public int GetValue()
            //    {
            //        return _value;
            //    }
        }
    }
}
