class Danhsachkhoahoc
{
    List<Khoahoc> khoahoc = new List<Khoahoc>(); 
    
    public bool ThemKhoaHoc(Khoahoc khoahoc)
    {
        if (this.khoahoc.Contains(khoahoc))
        {
            return false;
        }
        else
        { this.khoahoc.Add(khoahoc); return true; }
    }
    public void TimkiemKH()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.Write("Mời bạn nhập khoá học muốn tìm: ");
        string kh = Console.ReadLine();
        foreach (var item in khoahoc)
        {
            if (item.TenKhoaHoc == kh)
            {
                System.Console.WriteLine(item);
            }
            else System.Console.WriteLine("Không có khoá học bạn cần tìm ");
        }
    }
    public void DanhsachHVhocKH()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;        
        System.Console.Write("Mời bạn nhập tên học viên: ");
        string tenhv = Console.ReadLine();
        System.Console.Write($"Danh sách những lớp học của {tenhv}: ");
        foreach (var item in khoahoc)
        {
            foreach (var item1 in item.Tatcahocvien())
            {
                if (item1.HoTen.Equals(tenhv))
                {
                    
                    System.Console.Write(item.TenKhoaHoc + ", " );
                }
            }
        }
        System.Console.WriteLine();
    }
    public void CacKHchuaketthuc()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine("Các khoá học chưa kết thúc: ");
        List<Khoahoc> dsKHchuaketthuc = new List<Khoahoc>();
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        foreach (var item in khoahoc)
        {
            if (item.ThoiGianKetThuc > today) System.Console.WriteLine(item.TenKhoaHoc);
        }
    }
    public void CacKHchuabatdau()
    {   Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine("Các khoá học chưa bắt đầu: ");
        List<Khoahoc> dsKHchuabatdau = new List<Khoahoc>();
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        foreach (var item in khoahoc)
        {
            if (item.NgayMoKhoaHoc > today) System.Console.WriteLine(item.TenKhoaHoc);
        }
    }
}