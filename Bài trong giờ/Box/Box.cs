using System;
using Rectang;
namespace Boxsm
{
    public class Box : Rectangle
    {
        public int height;
        internal int price;
        internal int weight;
        public void setSize(int l, int w, int h)
        {
            base.setSize(l, w);
            height = h > 0 ? h : 0;
        }
        public int volume()
        {
            return length * width * height;
        }

    }
}