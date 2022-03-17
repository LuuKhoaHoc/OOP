class HoaDonTheoGio : HoaDon
{
    private int _soGioThue;
    public int SoGioThue { get => _soGioThue; set => _soGioThue = value < 30 ? value : throw new Exception("Số giờ thuê phải bé hơn 30"); }

    public HoaDonTheoGio(int maHoadon, DateOnly ngayHoadon, string tenkhachhang, int maPhong, int donGia, int soGioThue)
    : base(maHoadon, ngayHoadon, tenkhachhang, maPhong, donGia)
    {
        SoGioThue = soGioThue;
    }

    public override void toString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine($"|{MaHoadon,10}|{NgayHoadon,20}|{Tenkhachhang,30}|{MaPhong,10}|{DonGia,15}|{Thanhtien(),20}|{"Hoá đơn theo giờ ",20}|");
    }
    public override double Thanhtien() => (SoGioThue < 24) ? SoGioThue * DonGia : 24 * DonGia;

}