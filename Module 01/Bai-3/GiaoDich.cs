abstract class GiaoDich
{
    private string _maGiaodich = "";
    private DateOnly _ngayGiaodich;
    private int _donGia;
    private int _soLuong;

    public GiaoDich(string maGiaodich, DateOnly ngayGiaodich, int donGia, int soLuong)
    {
        MaGiaodich = maGiaodich;
        NgayGiaodich = ngayGiaodich;
        DonGia = donGia;
        SoLuong = soLuong;
    }

    public abstract void toString();
    public abstract double ThanhTien();

    public string MaGiaodich { get => _maGiaodich; set => _maGiaodich = value; }
    public DateOnly NgayGiaodich { get => _ngayGiaodich; set => _ngayGiaodich = value; }
    public int DonGia { get => _donGia; set => _donGia = value; }
    public int SoLuong { get => _soLuong; set => _soLuong = value; }

}