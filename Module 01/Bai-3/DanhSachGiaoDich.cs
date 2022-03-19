class DanhSachGiaoDich
{
    List<GiaoDich> gd = new List<GiaoDich>();
    public void ThemGiaoDich(GiaoDich giaodich)
    {
        gd.Add(giaodich);
    }
    public void TinhTongTungLoai()
    {
        double sumtt = 0;
        double sumvang = 0;
        foreach (var item in gd)
        {
            if (item is GiaoDichTienTe)
            {
                sumtt += item.ThanhTien();
            }
            System.Console.WriteLine();
            if (item is GiaoDichVang)
            {
                sumvang += item.ThanhTien();
            }
        }
        System.Console.WriteLine("Tổng giao dịch tt: " + sumtt);
        System.Console.WriteLine("Tổng giao dịch vàng: " + sumvang);
    }
    public double TinhTBGDTT()
    {
        double sum = 0;
        int sogd = 0;
        foreach (var item in gd)
        {
            if (item is GiaoDichTienTe)
            {
                sum += item.ThanhTien();
                sogd += item.SoLuong;
            }
        }
        return (sogd != 0) ? sum / sogd : 0;
    }
    public void XuatGD1ty()
    {
        DungChung.printtitle();
        foreach (var item in gd)
        {
            if (item.ThanhTien() > 1000000000)
            {
                item.toString();
            }
        }
        DungChung.printline();
    }
}