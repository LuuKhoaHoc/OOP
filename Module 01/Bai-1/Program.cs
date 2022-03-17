using System.Collections;
System.Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Chuyenxenoithanh> arrchuyenxenoithanh = new List<Chuyenxenoithanh>();
List<Chuyenxengoaithanh> arrchuyenxengoaithanh = new List<Chuyenxengoaithanh>();
int soChuyenNoiThanh, soChuyenNgoaiThanh;
double doanhThuXeNoiThanh = 0, doanhThuXeNgoaiThanh = 0;
System.Console.Write("Nhập số chuyến xe nội thành:");
soChuyenNoiThanh = int.Parse(Console.ReadLine());
System.Console.Write("Nhập số chuyến xe ngoại thành:");
soChuyenNgoaiThanh = int.Parse(Console.ReadLine());

System.Console.WriteLine("Nhập thông tin chuyến xe nội thành:");
for (int i = 0; i < soChuyenNoiThanh; i++)
{
    System.Console.WriteLine("Nhập thông tin chuyến xe thứ "+ (i+1)+ ":");
    Chuyenxenoithanh chuyenxenoithanh = new Chuyenxenoithanh();
    chuyenxenoithanh.nhapthongtinchuyenxe();
    doanhThuXeNoiThanh = doanhThuXeNoiThanh + chuyenxenoithanh.getdoanhThu();
    arrchuyenxenoithanh.Add(chuyenxenoithanh); 
}
System.Console.WriteLine("Nhập thông tin chuyến xe ngoại thành:");
for (int i = 0; i < soChuyenNgoaiThanh; i++)
{
    System.Console.WriteLine("Nhập thông tin chuyến xe thứ"+ (i+1)+ ":");
    Chuyenxengoaithanh chuyenxengoaithanh = new Chuyenxengoaithanh();
    chuyenxengoaithanh.nhapthongtinchuyenxe();
    doanhThuXeNgoaiThanh += chuyenxengoaithanh.getdoanhThu();
    arrchuyenxengoaithanh.Add(chuyenxengoaithanh); 
}

System.Console.WriteLine("---------------Thông tin chuyến xe nội thành---------------");
foreach (var item in arrchuyenxenoithanh)
{
    System.Console.WriteLine(item.toString());
}
System.Console.WriteLine("---------------Thông tin chuyến xe ngoại thành---------------");
foreach (var item in arrchuyenxengoaithanh)
{
    System.Console.WriteLine(item.toString());
}

System.Console.WriteLine("Doanh thu từng chuyến xe:");
System.Console.WriteLine("Doanh thu chuyến xe nội thành: " +doanhThuXeNoiThanh);
System.Console.WriteLine("Doanh thu chuyến xe ngoại thành: " +doanhThuXeNgoaiThanh);