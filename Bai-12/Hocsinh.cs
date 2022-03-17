 class Hocsinh
{
    private string _hoTen = "";
    private string _diaChi = "";
    private int _sdt;

    public Hocsinh(string hoTen, string diaChi, int sdt)
    {
        HoTen = hoTen;
        DiaChi = diaChi;
        Sdt = sdt;
    }

    public string HoTen { get => _hoTen; set => _hoTen = value; }
    public string DiaChi { get => _diaChi; set => _diaChi = value; }
    public int Sdt { get => _sdt; set => _sdt = value; }

 
}