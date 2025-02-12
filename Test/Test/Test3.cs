using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Square box = new Square();
            Console.WriteLine(box.Area());
        }
    }

    class Square
    {
        float width;
        float height;

        public float Area() { return width * height; }
    }
}
