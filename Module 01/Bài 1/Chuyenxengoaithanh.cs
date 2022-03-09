public class Chuyenxengoaithanh : Chuyenxe
{
    private string noiden { get; set; }
    private int songaydiduoc { get; set; }
    public Chuyenxengoaithanh()
    {
    }

    public Chuyenxengoaithanh(string masochuyen, string hotentaixe, string soxe, double doanhThu, string noiden, int songaydiduoc) : base(masochuyen, hotentaixe, soxe, doanhThu)
    {
        this.noiden = noiden;
        this.songaydiduoc = songaydiduoc;
    }

    public string toString()
    {
        return base.toString() + ", nơi đến: " + this.noiden +
                ", số ngày đi được: " + this.songaydiduoc;
    }
        public void nhapthongtinchuyenxe(){
        base.nhapthongtinchuyenxe();
        System.Console.Write("Mời bạn nhập nơi đến: ");
        noiden = Console.ReadLine();
        System.Console.Write("Mời bạn nhập số ngày đi được: ");
        songaydiduoc = int.Parse(Console.ReadLine());
    }
}