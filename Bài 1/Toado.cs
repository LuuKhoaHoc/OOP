using System;

namespace OOP
{
    class Toado
    {
        private int x;
        private int y;
        private string name;

        public Toado(int x, int y, string name)
        {
            setx(x);
            sety(y);
            setname(name);
        }
        public Toado()
        {
        }
        public void setx(int x)
        {
            this.x = x;
        }
        public void sety(int y)
        {
            this.y = y;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return $"{this.name} ({this.x}, {this.y})";
        }
    }
}
