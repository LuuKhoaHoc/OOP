class SachThamKhao : Sach
{
    private float thue;
    public float Thue { get => thue; set => thue = value; }

    public SachThamKhao(string maSach, DateOnly ngayNhap, int donGia, string nhaXuatBan, int soLuong, float thue) 
    : base(maSach, ngayNhap, donGia, nhaXuatBan, soLuong)
    {
        Thue = thue;
    }
    public override double Thanhtien() => SoLuong*DonGia+Thue;
    public override void toString(){}
}