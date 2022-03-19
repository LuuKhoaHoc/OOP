DanhSachGiaoDich dsgt = new DanhSachGiaoDich();
Console.OutputEncoding = System.Text.Encoding.UTF8;

dsgt.ThemGiaoDich(new GiaoDichTienTe("111", new DateOnly(2022, 01, 12), 300000, 10, "VND"));
dsgt.ThemGiaoDich(new GiaoDichTienTe("112", new DateOnly(2022, 01, 11), 200000, 5, "Euro"));
dsgt.ThemGiaoDich(new GiaoDichTienTe("113", new DateOnly(2022, 01, 15), 400000, 7, "USD"));

dsgt.ThemGiaoDich(new GiaoDichVang("222", new DateOnly(2021, 12, 23), 2000000, 4, "24k"));
dsgt.ThemGiaoDich(new GiaoDichVang("223", new DateOnly(2021, 12, 25), 5000000, 5, "36k"));
dsgt.ThemGiaoDich(new GiaoDichVang("224", new DateOnly(2021, 12, 28), 9000000, 9, "99k"));
dsgt.TinhTongTungLoai();
System.Console.WriteLine("Các giao dịch trên 1 tỷ đồng: "); dsgt.XuatGD1ty();
System.Console.WriteLine("Số tiền trung bình của giao dịch tiền tệ là: " + dsgt.TinhTBGDTT());



