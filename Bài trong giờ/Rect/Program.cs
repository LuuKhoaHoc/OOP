using System;
namespace Rectang
{
    public class Rectangle
    {
        public int length;
        public int width;
        public void setSize(int l, int w)
        {
            length = l > 0 ? l : 0;
            width = w > 0 ? l : 0;
        }
    }
}