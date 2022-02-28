using System;

namespace Bài_4
{
    class Vehicle
    {
        private string owner;
        private string type;
        private int price;
        private int xylanh;
        public Vehicle()
        {
            owner = "unknown";
            type = "unknown";
            price = 0;
            xylanh = 0;
        }
        public Vehicle(string newowner, string newtype, int newprice, int newxylanh)
        {
            if (newowner != string.Empty) owner = newowner; else owner = "unknown";
            if (newtype != string.Empty) type = newtype; else type = "unknown";
            if (newprice < 0) price = 0; else price = newprice;
            if (newxylanh <0) xylanh = 0; else xylanh = newxylanh;
        }
        public float tax(){
            if (xylanh <100) return (price * 1/100);
            else if (xylanh <200) return (price * 3/100);
            else return (price * 5/100);
        }
        public void toString(){
            System.Console.WriteLine("|{0,-15}|{1,15}|{2,10}|{3,20}|{4,20}|", owner, type, xylanh, price, this.tax());
        }
        public static void title(){
            for (int i = 0; i < 86; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("|{0,-15}|{1,-15}|{2,-10}|{3,-20}|{4,-20}|","Chu xe", "Loai xe", "xylanh", "Gia", "Thue");
            for (int i = 0; i < 86; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        public static void ending(){
            for (int i = 0; i < 86; i++)
            {
                System.Console.Write("*");
            }
        }
        
    }
}