using System;
using System.Globalization;
using System.Threading;
class Account
{

    private long _accountNumber;
    private string _name;
    private double _balance;
    private double _RATE = 0.035;

    public long AccountNumber { get => _accountNumber; set => _accountNumber = value < 0 ? 9999999 : value; }
    public string Name { get => _name; set => _name = value.Trim() != string.Empty ? value.Trim() : "Chưa xác định"; }
    public double Balance { get => _balance; set => _balance = value < 0 ? 50000 : value; }

    public Account()
    {
        AccountNumber = 9999999;
        Name = "Chưa xác định";
        Balance = 50000;
    }


    public Account(long accountNumber, string name)
    {
        AccountNumber = accountNumber;
        Name = name;
    }

    public Account(long accountNumber, string name, double balance)
    {
        AccountNumber = accountNumber;
        Name = name;
        Balance = balance;
    }
    
    public void Deposit()
    {
        bool check1 = true;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (check1)
        {

            System.Console.Write($"Số tiền bạn muốn gửi vào tài khoản {AccountNumber},{Name}: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount < 0)
            {
                System.Console.WriteLine("Bạn vừa nhập giá trị không hợp lệ, mời bạn nhập lại");
            }
            else System.Console.WriteLine("Bạn đã gửi tiền vào tài khoản thành công"); check1 = false;
        }
    }
    public void Withdraw()
    {
        bool check2 = true;
        double fee = 1.50;
        while (check2)
        {
            System.Console.Write($"Số tiền bạn muốn rút khỏi tài khoản {AccountNumber},{Name}: ");
            double amount = double.Parse(Console.ReadLine());
            if ((amount < 0) && (amount + fee <= Balance))
            {
                System.Console.WriteLine("Bạn vừa nhập giá trị không hợp lệ, mời bạn nhập lại");
            }
            else Balance = Balance - (amount + fee); System.Console.WriteLine("Đã rút tiền thành công"); check2 = false;
        }
    }
    public void AddInterest()
    {
        Balance = Balance + Balance * _RATE;
        System.Console.WriteLine($"Tiền lãi của tài khoản {AccountNumber},{Name}: {Balance}");
    }
    public void Tranfer(ref Account account2, double amount)
    {
        Balance -= amount;
        account2.Balance += amount;
        System.Console.WriteLine($"Bạn vừa chuyển tiền cho tài khoản {account2.Name}");
    }
    public override string ToString()
    {
        return $"|{AccountNumber,15}|{Name,20}|{Balance,20}|";
    }
    public static void Title()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        line();
        System.Console.WriteLine($"|{"Số tài khoản",-15}|{"Chủ tài khoản",-20}|{"Số tiền",-20}|");
        line();
    }
    public static void line()
    {
        for (int i = 0; i < 59; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}