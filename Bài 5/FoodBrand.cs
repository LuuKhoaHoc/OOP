class FoodBrand
{
    private string id;
    private string name;
    private int price;
    private DateOnly NSX;
    private DateOnly EXP;
    readonly DateOnly today = DateOnly.FromDateTime(DateTime.Today);

    public FoodBrand(string ID, string Name, int Price, DateOnly nsx, DateOnly exp)
    {
        if (ID.Trim() != string.Empty) id = ID;
        setname(Name);
        setprice(Price);
        setNSX(nsx);
        setEXP(exp);
    }
    public FoodBrand(string id)
    {
        if (id.Trim() == string.Empty) System.Console.WriteLine("Loi: Ma hang rong\n + Khong the tao doi tuong");
        else
        {
            name = "xxx";
            price = 0;
            NSX = today;
            EXP = today;
        }
    }
    public void setname(string name)
    {
        if (name == string.Empty) this.name = "xxx";
        else this.name = name;
    }
    public void setprice(int price)
    {
        if (price >= 0)
        {
            this.price = price;
        }
        else price = 0;
    }

    public void setNSX(DateOnly newNSX)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        if (newNSX < today) NSX = newNSX;
        else NSX = today;

    }
    public void setEXP(DateOnly newEXP)
    {        
        if (newEXP > NSX) EXP = newEXP;
        else EXP = NSX;
    }
    public bool hethan()
    {
        return (EXP < today);
    }
    public override string ToString()
    {
        string note = (hethan() ? "Out of date" : "");
        return $"|{id,-10}|{name,-10}|{price,-10}|{NSX,20}|{EXP,20}|{note,15}|";
    }
    public static void title(){
        line();
        System.Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,20}|{4,20}|{5,15}|", "id", "name", "price", "NSX", "EXP","Note");
        line();
    }
    public static void line(){
        for (int i = 0; i < 92; i++)
        {
            System.Console.Write("-");
        }
        System.Console.WriteLine();
    }
    public string getname() { return this.name; }
    public string getid() { return this.id; }
    public int getprice() { return this.price; }
    public DateOnly getNSX() { return this.NSX; }
    public DateOnly getEXP() { return this.EXP; }


}