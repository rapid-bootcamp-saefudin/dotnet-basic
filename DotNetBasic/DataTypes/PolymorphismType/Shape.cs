using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.PolymorphismType
{
    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Kelas dasar untuk melakukan tugas menggambar");
        }
    }

    public class Lingkaran : Shape
    {
        public override void Draw()
        {
            // Code untuk menggambar Lingkaran...
            Console.WriteLine("Menggambar Lingkaran");
            base.Draw();
        }
    }
    public class PersegiPanjang : Shape
    {
        public override void Draw()
        {
            // Code untuk menggambar rectangle...
            Console.WriteLine("Menggambar Persegi Panjang");
            base.Draw();
        }
    }
    public class Segitiga : Shape
    {
        public override void Draw()
        {
            // Code untuk menggambar triangle...
            Console.WriteLine("Menggambar Segitiga");
            base.Draw();
        }
    }
}
