class Khoahoc
{
    private string _tenKhoaHoc = ""; 
    private DateOnly _ngayMoKhoaHoc;
    private DateOnly _thoiGianKetThuc;
    private List<Hocsinh> dshocsinh = new List<Hocsinh>();

    public Khoahoc(string tenKhoaHoc, DateOnly ngayMoKhoaHoc, DateOnly thoiGianKetThuc)
    {
        TenKhoaHoc = tenKhoaHoc;
        NgayMoKhoaHoc = ngayMoKhoaHoc;
        ThoiGianKetThuc = thoiGianKetThuc;
    }

    public void Themhocsinh(Hocsinh hocsinh){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        if (dshocsinh.Count <=20)
        {
            Dshocsinh.Add(hocsinh);
        } else 
            throw new Exception("Quá giới hạn học viên");
        
    }
    public List<Hocsinh> Tatcahocvien(){
        return Dshocsinh;
    }

    public string TenKhoaHoc { get => _tenKhoaHoc; set => _tenKhoaHoc = value; }
    public DateOnly NgayMoKhoaHoc { get => _ngayMoKhoaHoc; set => _ngayMoKhoaHoc = value; }
    public DateOnly ThoiGianKetThuc { get => _thoiGianKetThuc; set => _thoiGianKetThuc = value; }
    internal List<Hocsinh> Dshocsinh { get => dshocsinh; set => dshocsinh = value; }

       public override bool Equals(object? obj)
    {
        Khoahoc kh1 = obj as Khoahoc;
        return kh1.TenKhoaHoc.Equals(TenKhoaHoc);
    }
}