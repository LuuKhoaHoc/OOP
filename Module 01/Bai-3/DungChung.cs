public class DungChung
{
    public static void printline()
    {
        for (int i = 0; i < 86; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
    public static void printtitle()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        printline();
        Console.WriteLine($"|{"Mã giao dịch",-15}|{"Ngày giao dịch",-20}|{"Đơn giá",-15}|{"Số lượng",-10}|{"Loại giao dịch",-20}|");
        printline();
    }
    public static void printtitle_thanhtien()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        printline();
        Console.WriteLine($"|{"Mã giao dịch",10}|{"Loại giao dịch",20}|{"Thành tiền",20}|");
        printline();
    }
}