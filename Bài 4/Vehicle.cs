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
            
        }
        public float tax(){
            if (xylanh <100) return (price * 1/100);
            else if (xylanh <200) return (price * 3/100);
            else return (price * 5/100);
        }


    }
}