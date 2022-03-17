using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Toado toado = new Toado();
            toado.setx(1);
            toado.sety(1);
            toado.setname("X");

            System.Console.WriteLine(toado.getX());
            System.Console.WriteLine(toado.getY());
            System.Console.WriteLine(toado.getName());

            Toado toado1 = new Toado(2,2,"Y");
            
            System.Console.WriteLine(toado1);
            System.Console.WriteLine();
        }
    }
}
