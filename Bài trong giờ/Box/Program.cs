using System;
using Rectang;

namespace Boxsm
{
    public class Demo_1
    {
        public void Main(string[] args)
        {
            Box b = new Box();
            b.setSize(1, 2, 3);
            b.height = 10;
            b.price = 7;
            b.weight = 9;
            System.Console.WriteLine("Volumn of the box:" + b.volume());
            Rectangle r = new Rectangle();
            r.setSize(3, 5);
            r.width = 3;
            r.length = 6;
        }
    }
}