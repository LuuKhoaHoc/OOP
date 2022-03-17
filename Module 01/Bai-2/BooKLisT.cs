class BooKLisT
{
    
    List<Sach> lisT = new List<Sach>();
    public double TinhtongtienSGK()
    {
        double sum = 0;
        foreach (var item in lisT)
        {
            if (item is SachGiaoKhoa)
            {
                sum += item.Thanhtien();
            }
        }
        return sum;
    }
    public double TinhtongtienSTK()
    {
        double sum = 0;
        foreach (var item in lisT)
        {
            if (item is SachThamKhao)
            {
                sum += item.Thanhtien();
            }
        }
        return sum;
    }
    public double TbcSTK()
    {
        double tbc = 0;
        int soLuong = 0;
        foreach (var item in lisT)
        {
            if (item is SachThamKhao)
            {
                tbc += item.Thanhtien();
                soLuong += item.SoLuong;
            }

        }
        return (soLuong != 0) ? tbc / soLuong : 0;
    }
    public void ThemsacH(Sach sach)
    {
        lisT.Add(sach);
    }
    public void Xuatthongtin()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine("Mời bạn nhập nhà xuất bản của sách giáo khoa: ");
        string nxb = Console.ReadLine();
        Title();
        foreach (var item in lisT)
        {
            if (item is SachGiaoKhoa && item.NhaXuatBan == nxb)
            {
                item.toString();
            }
        }
        line();
        
    }

    public static void Title()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        line();
        System.Console.WriteLine($"|{"Mã sách",-10}|{"Ngày nhập",-20}|{"Đơn giá",-10}|{"Nhà xuất bản",-20}|{"Số lượng",-10}|{"Thành Tiền",-15}|");
        line();
    }
    public static void line()
    {
        for (int i = 0; i < 92; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}