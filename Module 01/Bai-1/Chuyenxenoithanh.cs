public class Chuyenxenoithanh : Chuyenxe
{
    private string sotuyen { get; set; }
    private float sokmdiduoc { get; set; }
    public Chuyenxenoithanh()
    {
    }

    public Chuyenxenoithanh(string masochuyen, string hotentaixe, string soxe, double doanhThu, string sotuyen, float sokmdiduoc) : base(masochuyen, hotentaixe, soxe, doanhThu)
    {
        this.sotuyen = sotuyen;
        this.sokmdiduoc = sokmdiduoc;
    }

    public string toString()
    {
        return base.toString() + ", số tuyến: " + this.sotuyen +
                ", số km đi được: " + this.sokmdiduoc;
    }
    public void nhapthongtinchuyenxe(){
        base.nhapthongtinchuyenxe();
        System.Console.Write("Mời bạn nhập số tuyến: ");
        sotuyen = Console.ReadLine();
        System.Console.Write("Mời bạn nhập số km đi được: ");
        sokmdiduoc = float.Parse(Console.ReadLine());
    }
}