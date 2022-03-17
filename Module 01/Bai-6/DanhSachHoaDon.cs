class DanhSachHoaDon
{
    List<HoaDon> list = new List<HoaDon>();

    public bool ThemHoaDon(HoaDon hoaDon)
    {
        if (list.Contains(hoaDon))
        {
            return false;
        }
        else { list.Add(hoaDon); return true; }
    }

    public void Xuat()
    {
        Title();
        foreach (var item in list)
        {
            item.toString();
        }
        line();
    }
    public void ThongkeSoluongHDTheoGio()
    {
        int count = 0;
        foreach (var item in list)
        {
            if (item is HoaDonTheoGio)
            {
                count++;
            }
        }
        System.Console.WriteLine("Tổng số hoá đơn tính theo giờ: " + count);
    }
    public void ThongkeSoluongHDTheoNgay()
    {
        int count = 0;
        foreach (var item in list)
        {
            if (item is HoaDonTheoNgay)
            {
                count++;
            }
        }
        System.Console.WriteLine("Tổng có hoá đơn theo ngày: " + count);
    }
    public void TinhtongThanhTien()
    {
        System.Console.Write("Mời bạn nhập tháng: ");
        int thang = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập năm: ");
        int nam = int.Parse(Console.ReadLine());
        if (thang < 1 || thang > 12)
        {
            throw new Exception("Tháng lộn kìa mẹ!!!");
        }
        double sum = 0;
        foreach (var item in list)
        {
            if (item.NgayHoadon >= new DateOnly(nam, thang, 1) && item.NgayHoadon < new DateOnly(nam, thang, 1).AddMonths(1))
            {
                sum += item.Thanhtien();
            }
        }
        System.Console.WriteLine($"Tổng tiền của {thang}/{nam} sau 1 tháng: {0:0,000}", sum);
    }
    public void ThemHoaDonTheoGio()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.Write("Mời bạn nhập mã hoá đơn: ");
        int newmahd = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập ngày hoá đơn: ");
        DateOnly billDate = DateOnly.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập tên khách hàng: ");
        string newkh = Console.ReadLine();
        System.Console.Write("Mời bạn nhập mã phòng: ");
        int newmaphong = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập đơn giá: ");
        int newdongia = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập số giờ thuê: ");
        int newhour = int.Parse(Console.ReadLine());
        ThemHoaDon(new HoaDonTheoGio(newmahd, billDate, newkh, newmaphong, newdongia, newhour));
    }
    public void ThemHoaDonTheoNgay()

    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.Write("Mời bạn nhập mã hoá đơn: ");
        int newmahd1 = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập ngày hoá đơn: ");
        DateOnly billDate = DateOnly.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập tên khách hàng: ");
        string newkh1 = Console.ReadLine();
        System.Console.Write("Mời bạn nhập mã phòng: ");
        int newmaphong1 = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập đơn giá: ");
        int newdongia1 = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập số ngày thuê: ");
        int newday = int.Parse(Console.ReadLine());
        ThemHoaDon(new HoaDonTheoNgay(newmahd1, billDate, newkh1, newmaphong1, newdongia1, newday));
    }
    public static void Title()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        line();
        System.Console.WriteLine($"|{"Mã Hoá Đơn",10}|{"Ngày Hoá Đơn",20}|{"Tên khách hàng",30}|{"Mã Phòng",10}|{"Đơn Giá",15}|{"Thành tiền",20}|{"Loại Hoá Đơn",20}|");
        line();
    }
    public static void line()
    {
        for (int i = 0; i < 133; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}