using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Inheritance.SampleInheritance;

namespace Inheritance
{
    public class MainInheritance
    {
        public static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());
        }
    }
    // The example displays the following output:
    //       10    }
}
