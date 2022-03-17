class HoaDonTheoNgay : HoaDon
{
    private int _sonNgayThue;
    public int SoNgayThue { get => _sonNgayThue; set => _sonNgayThue = value < 30 ? value : throw new Exception("Số giờ thuê phải bé hơn 30"); }

    public HoaDonTheoNgay(int maHoadon, DateOnly ngayHoadon, string tenkhachhang, int maPhong, int donGia, int soNgayThue)
    : base(maHoadon, ngayHoadon, tenkhachhang, maPhong, donGia)
    {
        SoNgayThue = soNgayThue;
    }

    public override void toString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine($"|{MaHoadon,10}|{NgayHoadon,20}|{Tenkhachhang,30}|{MaPhong,10}|{DonGia,15}|{Thanhtien(),20}|{"Hoá đơn theo ngày ",20}|");
    }
    public override double Thanhtien() => (SoNgayThue < 7) ? SoNgayThue * DonGia : 7 * DonGia + 0.8 * (SoNgayThue - 7) * DonGia;

}