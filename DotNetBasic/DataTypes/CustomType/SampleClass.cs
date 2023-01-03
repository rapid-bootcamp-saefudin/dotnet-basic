using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes.CustomType;


namespace DataTypes.CustomType
{
    //Nama Class
    public class SampleClass
    {
        public int dataX;
        public int dataY;

        //Contructor
        public SampleClass()
        {
        }

        //Contructor
        public SampleClass(int x, int y)
        {
            dataX = x;
            dataY = y;
        }

        public override string ToString()
        {
            return "SampleClass [x : " + dataX + ", y : " + dataY + "]";
        }
    }
}
