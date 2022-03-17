Console.OutputEncoding = System.Text.Encoding.UTF8;
DanhSachHoaDon dshd = new DanhSachHoaDon();

System.Console.WriteLine("-------------Mời bạn chọn-------------");
System.Console.WriteLine(
"1. Tạo danh sách hoá đơn\n" +
"2. Thêm hoá đơn theo giờ vào danh sách\n" +
"3. Thêm hoá đơn theo ngày vào danh sách\n" +
"4. Xuất hoá đơn\n" +
"5. Thống kê số lượng hoá đơn theo giờ\n" +
"6. Thống kê số lượng hoá đơn theo ngày\n" +
"7. Tính tổng thành tiền\n" +
"8. Thoát khỏi chương trình\n" +
"--------------------------------------"

);
bool check2 = true;
while (check2)
{
    System.Console.Write("Bạn chọn gì: ");
    switch (Console.ReadLine())
    {
        case "1":
            dshd = new DanhSachHoaDon();
            System.Console.WriteLine("Đã tạo danh sách hoá đơn");
            break;
        case "2":
            dshd.ThemHoaDonTheoGio();
            break;
        case "3":
            dshd.ThemHoaDonTheoNgay();
            break;
        case "4":
            dshd.Xuat();
            break;
        case "5":
            dshd.ThongkeSoluongHDTheoGio();
            break;
        case "6":
            dshd.ThongkeSoluongHDTheoNgay();
            break;
        case "7":
            dshd.TinhtongThanhTien();
            break;
        default:
            check2 = false;
            break;
    }
}
