
public class CongNhan : IComparable
{
    private int mCN;
    private string mHo;
    private string mTen;
    private int mSoSP;

    public int MCN { get => mCN; set => mCN = value; }
    public string MHo { get => mHo; set => mHo = value; }
    public string MTen { get => mTen; set => mTen = value; }
    public int MSoSP { get => mSoSP; set { if (value > 0) { this.mSoSP = value; } else mSoSP = 99999; } }

    public CongNhan()
    {
    }
    public CongNhan(int newmCN, string newmHo, string newmTen, int newmSoSP)
    {
        MCN = newmCN;
        MHo = newmHo;
        MTen = newmTen;
        MSoSP = newmSoSP;
    }
    public double tinhLuong()
    {
        if (mSoSP >= 1 && mSoSP <= 199)
        {
            return mSoSP * 0.5;
        }
        else if (mSoSP >= 200 && mSoSP <= 399)
        {
            return mSoSP * 0.55;
        }
        else if (mSoSP >= 400 && mSoSP <= 599)
        {
            return mSoSP * 0.6;
        }
        else return mSoSP * 0.6;
    }
    public override string ToString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        return $"|{mCN,5}|{mHo,10}|{mTen,10}|{mSoSP,15}|";
    }
        public static void title()
    {
        line();
        System.Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,15}|", "mCN", "Họ", "Tên", "Số sản phẩm");
        line();
    }
    public static void line()
    {
        for (int i = 0; i < 45; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }

    public int CompareTo(object? obj)
    {
        CongNhan cn = obj as CongNhan;
        return -mSoSP.CompareTo(cn.mSoSP);
    }
}