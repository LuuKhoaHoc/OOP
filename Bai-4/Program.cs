using System;

namespace Bài_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vehicle("Khoa Hoc","Toyota",100000,100);
            var v1 = new Vehicle("Vi Phong","Honda",150000,1000);
            var v2 = new Vehicle("Minh Thinh","Suzuki",120000,500);

            Vehicle.title();
            v.tax();            
            v.toString();
            v1.tax();
            v1.toString();
            v2.tax();
            v2.toString();
            Vehicle.ending();

            Console.ReadKey();
        }
    }
}
