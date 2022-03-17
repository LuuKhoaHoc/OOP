abstract class HoaDon
{
    private int _maHoadon;
    private DateOnly _ngayHoadon;
    private string _tenkhachhang = "";
    private int _maPhong;
    private int _donGia;


    public HoaDon(int maHoadon, DateOnly ngayHoadon, string tenkhachhang, int maPhong, int donGia)
    {
        _maHoadon = maHoadon;
        _ngayHoadon = ngayHoadon;
        _tenkhachhang = tenkhachhang;
        _maPhong = maPhong;
        _donGia = donGia;
    }

    public int MaHoadon { get => _maHoadon; set => _maHoadon = value; }
    public DateOnly NgayHoadon { get => _ngayHoadon; set => _ngayHoadon = value; }
    public string Tenkhachhang { get => _tenkhachhang; set => _tenkhachhang = value; }
    public int MaPhong { get => _maPhong; set => _maPhong = value; }
    public int DonGia { get => _donGia; set => _donGia = value; }

    public abstract void toString();
    public abstract double Thanhtien();
    public override bool Equals(object? obj)
    {
        HoaDon hoadon1 = obj as HoaDon;
        return hoadon1.MaHoadon.Equals(MaHoadon);
    }
}