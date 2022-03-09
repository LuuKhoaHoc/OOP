public class Chuyenxe
{
    protected string masochuyen, hotentaixe, soxe;
    protected double doanhThu;

    public Chuyenxe()
    {
        this.masochuyen = "";
        this.hotentaixe = "";
        this.soxe = "";
        this.doanhThu = 0;
    }

    public Chuyenxe(string masochuyen, string hotentaixe, string soxe, double doanhThu)
    {
        this.masochuyen = masochuyen;
        this.hotentaixe = hotentaixe;
        this.soxe = soxe;
        this.doanhThu = doanhThu;
    }
    public string getmasochuyen() {return masochuyen;}
    public string gethotentaixe() {return hotentaixe;}
    public string getsoxe() {return soxe;}
    public double getdoanhThu() {return doanhThu;}

    public void setmasochuyen(string masochuyen) {this.masochuyen = masochuyen;}
    public void sethotentaixe(string hotentaixe) {this.hotentaixe = hotentaixe;}
    public void setsoxe(string soxe) {this.soxe = soxe;}
    public void setdoanhThu(double doanhThu) {this.doanhThu = doanhThu;}

    public String toString() {
        return "Mã số chuyến: " + this.masochuyen + ", họ tên tài xế: " + this.hotentaixe
                + ", số xe: " + this.soxe + ", doanh thu: " + this.doanhThu;
    }

    public void nhapthongtinchuyenxe(){
        System.Console.Write("Mời bạn nhập mã số chuyến:");
        masochuyen = Console.ReadLine();
        System.Console.Write("Mời bạn nhập họ tên tài xế:");
        hotentaixe = Console.ReadLine();
        System.Console.Write("Mời bạn nhập số xe:");
        soxe = Console.ReadLine();
        System.Console.Write("Mời bạn nhập doanh thu:");
        doanhThu = double.Parse(Console.ReadLine());
    }
    
}
