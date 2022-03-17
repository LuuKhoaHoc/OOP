class SachGiaoKhoa : Sach
{
    private string _tinhTrang;
    public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }

    public SachGiaoKhoa(string maSach, DateOnly ngayNhap, int donGia, string nhaXuatBan, int soLuong, string tinhTrang)
    : base(maSach, ngayNhap, donGia, nhaXuatBan, soLuong)
    {
        TinhTrang = tinhTrang;
    }
    public override double Thanhtien() => _tinhTrang.Trim().ToLower() == "cu" ? SoLuong * DonGia * 0.5 : SoLuong * DonGia;

    public override void toString()
    {
        System.Console.WriteLine($"|{MaSach,10}|{NgayNhap,20}|{DonGia,10}|{NhaXuatBan,20}|{SoLuong,10}|{Thanhtien(),15:0,000}|");
    }
}