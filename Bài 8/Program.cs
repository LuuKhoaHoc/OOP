Console.OutputEncoding = System.Text.Encoding.UTF8;
CDList cD = new CDList();
System.Console.WriteLine("-------------Mời bạn chọn-------------");
System.Console.WriteLine(
"1. Tạo một danh sách mới\n" +
"2. Thêm một đĩa CD\n" +
"3. Số CD trong danh sách\n" +
"4. Tổng giá tiền CD\n" +
"5. Xuất thông tin CD\n" +
"6. Sắp xếp CD theo giá tiền\n" +
"7. Sắp xếp CD theo tựa CD\n" +
"8.Thoát khỏi chương trình\n" +
"--------------------------------------"

);
bool check2 = true;
while (check2)
{
    System.Console.Write("Bạn chọn gì: ");
    switch (Console.ReadLine())
    {
        case "1": cD = new CDList(); System.Console.WriteLine("Đã tạo danh sách mới"); break;
        case "2":
            System.Console.Write("Mời bạn nhập mã số CD: ");
            int newcd = int.Parse(Console.ReadLine());
            System.Console.Write("Mời bạn nhập tựa CD: ");
            string newnamecd = Console.ReadLine();
            System.Console.Write("Mời bạn nhập số bài hát của CD: ");
            int newsbh = int.Parse(Console.ReadLine());
            System.Console.Write("Mời bạn nhập giá thành của CD: ");
            float newprice = float.Parse(Console.ReadLine());
            cD.AddCD(newcd, newnamecd, newsbh, newprice); break;
        case "3": System.Console.WriteLine("Số CD trong danh sách: {0}", cD.CountCD()); break;
        case "4": System.Console.WriteLine("Tổng giá tiền của CD: {0}", cD.PriceCD()); break;
        case "5": cD.PrintCD(); break;
        case "6": cD.SortCDbyPrice(); System.Console.WriteLine("Đã sắp xếp CD theo giá tiền"); break;
        case "7": cD.SortCDbyName(); System.Console.WriteLine("Đã sắp xếp CD theo tựa"); break;
        default: check2 = false; break;
    }
}