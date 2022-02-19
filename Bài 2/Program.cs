using System;

namespace Bài_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sv1 = new Student(1, "Luu Khoa Hoc", 7.5f, 8.0f);
            var sv2 = new Student(2, "Ly Vi Phong", 9.0f, 10.0f);
            var sv3 = new Student();
            System.Console.Write("Ma so sv: "); sv3.setMSV(int.Parse(Console.ReadLine()));
            System.Console.Write("Ten sv: "); sv3.setTSV(Console.ReadLine());
            System.Console.Write("Diem ly thuyet: "); sv3.setDLT(float.Parse(Console.ReadLine()));
            System.Console.Write("Diem thuc hanh: "); sv3.setDTH(float.Parse(Console.ReadLine()));

            
            Student.title();
            sv1.toString();
            sv2.toString();
            sv3.toString();
            
            Student.end();
        }
    }
}
