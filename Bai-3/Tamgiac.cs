using System;

namespace Khoa_Học_bài_3
{
    class Tamgiac
    {
        private float ma;
        private float mb;
        private float mc;
        public Tamgiac()
        {
            ma = 0;
            mb = 0;
            mc = 0;
        }
        public Tamgiac(float ma, float mb, float mc)
        {
            if (((ma < 0) || (mb < 0) || (mc < 0)) && ((mb + mc < ma) || (ma + mc < mb) || (ma + mb < mc)))
            {
                ma = 0;
                mb = 0;
                mc = 0;
            }
            else {
                this.ma = ma;
                this.mb = mb;
                this.mc = mc;
            }
        }
        public string Kiemtratamgiac()
        {
            if ((ma == mb) && (ma == mc)) return "Tam giac deu";
            else if ((ma == mb) || (ma == mc) || (mb == mc)) return "Tam giac can";
            else if ((ma + mb > mc) || (mb + mc > ma) || (ma + mc > mb)) return "Tam giac thuong";
            else return "Khong phai tam giac";

        }
        public float Chuvitamgiac()
        {
            return ma + mb + mc;
        }
        public double dientichtamgiac()
        {
            return Math.Sqrt((ma + mb + mc) / 2 * ((ma + mb + mc) / 2 - ma) * ((ma + mb + mc) / 2 - mb) * ((ma + mb + mc) / 2 - mc));
        }
        public void ToString()
        {
            System.Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,20}|{4,10}|{5,20}|", ma, mb, mc, this.Kiemtratamgiac(), this.Chuvitamgiac(), this.dientichtamgiac());
        }
        public static void title()
        {
            for (int i = 0; i < 87; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("|{0,10}|{1,10}|{2,10}|{3,20}|{4,10}|{5,20}|", "MA", "MB", "MC", "Kieu tam giac", "Chu vi", "Dien tich");
            for (int i = 0; i < 77; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        public static void ending()
        {
            for (int i = 0; i < 87; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        public void setma(float ma)
        {
            if (ma > 0) this.ma = ma;
        }
        public void setmb(float mb)
        {
            if (mb > 0) this.mb = mb;
        }
        public void setmc(float mc)
        {
            if (mc > 0) this.mc = mc;
        }
        public float getma()
        {
            return this.ma;
        }
        public float getmb()
        {
            return this.mb;
        }
        public float getmc()
        {
            return this.mc;
        }

    }
}