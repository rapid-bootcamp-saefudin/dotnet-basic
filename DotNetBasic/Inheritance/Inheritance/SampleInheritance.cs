using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    public class SampleInheritance
    {
        // 1. 
        /*        public class A
                {
                    private int _value = 7210;

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
        */


        // 2.
        /*public class A
        {
            public void Method1()
            {
                // Method implementation.
            }
        }

        public class B : A
        { }*/


        // 3.
        /*public class A
        {
            public void Method1()
            {
                // Do something.
            }
        }

        public class B : A
        {
            public override void Method1() // Generates CS0506.
            {
                // Do something else.
            }
        }*/


        // 4.
        /*public abstract class A
        {
            public abstract void Method1();
        }

        public class B : A // Generates CS0534.
        {
            public void Method3()
            {
                // Do something.
            }
        }*/


    }
}
