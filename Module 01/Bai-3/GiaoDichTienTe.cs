class GiaoDichTienTe : GiaoDich
{
    private double _tiGia = 23000;
    private string _loaiTienTe = "";

    public GiaoDichTienTe(string maGiaodich, DateOnly ngayGiaodich, int donGia, int soLuong, string loaiTienTe)
    : base(maGiaodich, ngayGiaodich, donGia, soLuong)
    {
        LoaiTienTe = loaiTienTe;

    }

    public override void toString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"|{MaGiaodich,15}|{NgayGiaodich,20}|{DonGia,15}|{SoLuong,10}|{"Giao dịch tiền tệ",20}|");
    }

    public override double ThanhTien()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

    tiente:
        if (LoaiTienTe.Trim().ToLower() == "vnd")
        {
            return SoLuong * DonGia;
        }
        else if (LoaiTienTe.Trim().ToLower() == "usd")
        {
            return SoLuong * DonGia * _tiGia;
        }
        else if (LoaiTienTe.Trim().ToLower() == "euro")
        {
            return SoLuong * DonGia * _tiGia;
        }
        else System.Console.WriteLine("Chỉ có thể chọn 3 loại tiền tệ này: vnd, usd, euro "); goto tiente;
    }


    public string LoaiTienTe { get => _loaiTienTe; set => _loaiTienTe = value; }

}