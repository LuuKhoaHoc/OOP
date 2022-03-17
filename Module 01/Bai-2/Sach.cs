abstract class Sach
{
    private string _maSach = "";
    private DateOnly _ngayNhap;
    private int _donGia;
    private string _nhaXuatBan = "";
    private int _soLuong;


    protected Sach(string maSach, DateOnly ngayNhap, int donGia, string nhaXuatBan, int soLuong)
    {
        MaSach = maSach;
        NgayNhap = ngayNhap;
        DonGia = donGia;
        NhaXuatBan = nhaXuatBan;
        SoLuong = soLuong;
    }

    public string MaSach { get => _maSach; set => _maSach = value; }
    public DateOnly NgayNhap { get => _ngayNhap; set => _ngayNhap = value; }
    public int DonGia { get => _donGia; set => _donGia = value; }
    public string NhaXuatBan { get => _nhaXuatBan; set => _nhaXuatBan = value; }
    public int SoLuong { get => _soLuong; set => _soLuong = value; }

    public abstract double Thanhtien();   
    public abstract void toString();
}