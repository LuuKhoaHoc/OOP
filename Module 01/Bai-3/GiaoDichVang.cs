class GiaoDichVang : GiaoDich
{

    private string _loaiVang = "";

    public GiaoDichVang(string maGiaodich, DateOnly ngayGiaodich, int donGia, int soLuong, string loaiVang) : base(maGiaodich, ngayGiaodich, donGia, soLuong)
    {
        LoaiVang = loaiVang;
    }
    public override void toString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"|{MaGiaodich,10}|{NgayGiaodich,20}|{DonGia,15}|{SoLuong,10}|{"Giao dịch vàng",20}|");
    }
    public override double ThanhTien() => SoLuong * DonGia;
    public string LoaiVang { get => _loaiVang; set => _loaiVang = value; }
}