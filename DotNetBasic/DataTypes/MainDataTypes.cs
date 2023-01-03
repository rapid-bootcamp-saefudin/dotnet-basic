using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return "Coord (" + x + ", " + y + ")";
        }
    }

    public class MainDataType
    {
        public static void Main()
        {
            ContohEnum();
        }


        #region Contoh Enum
        public static void ContohEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Days: {0}", item);
            }

            Type fieldModel = typeof(EnumFileMode);
            foreach (var item in Enum.GetNames(fieldModel))
            {
                Console.WriteLine("FieldMode : {0}", item);
            }

            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
            Console.WriteLine("Color Red: {0}, GetName: {1}", Colors.Red, Enum.GetName(Colors.Red));

            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));

        }
        #endregion

        #region Contoh Coord
        public static void ContohCoord()
        {
            Coords point1 = new Coords(2, 5);
            Console.Write("Point 1 : " + point1);
            Console.WriteLine();

            Coords point2 = new Coords(5, 5);
            Console.Write("Point 2 : " + point2);
        }
        #endregion

        #region Contoh Data Type
        public static void ContohDataType()
        {
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 18, 21 };
            var query = from item in source
                        where item <= limit
                        select item;

            Console.WriteLine("Query results : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }

            var query2 = from item in source
                         where item % 2 == 1
                         select item;

            Console.WriteLine("Write item with odd : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }

            var query3 = from item in source
                         where item % 2 == 0
                         select item;

            Console.WriteLine("Write item with even : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }

            var query4 = from item in source
                         where item % 3 == 0
                         select item;

            Console.WriteLine("Write item with multiple 3 : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }
        }
        #endregion
    }
    //public class DataTypes
    //{
    //}
}