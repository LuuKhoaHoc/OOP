
public class CD : IComparable
{
    
    private int cd;
    private string namecd;
    private int sbh;
    private float price;

    public int Cd
    {
        get { return this.cd; }
        set
        {
            if (value > 0)
            {
                this.cd = value;
            }
            else cd = 999999;
        }
    }
    public string Namecd
    {
        get { return this.namecd; }
        set
        {
            {
                if (value.Trim() != string.Empty)
                {
                    this.namecd = value;
                }
                else namecd = "Nah";
            }
        }
    }
    public int Sbh
    {
        get { return this.sbh; }
        set
        {
            {
                if (value > 0)
                {
                    this.sbh = value;
                }
                else value.ToString("Nah");
            }
        }
    }
    public float Price
    {
        get { return this.price; }
        set
        {
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else price.ToString("Nah");
            }
        }
    }

    public CD()
    {
        cd = 999999;
        namecd = "chua xac dinh";
    }
    public CD(int newcd, string newnamecd, int newsbh, float newprice)
    {
        Cd = newcd;
        Namecd = newnamecd;
        Sbh = newsbh;
        Price = newprice;
    }
    public override string ToString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        return $"|{cd,5}|{namecd,25}|{sbh,5}|{price,20}|";
    }
    public static void title()
    {
        line();
        System.Console.WriteLine("|{0,-5}|{1,-25}|{2,-5}|{3,20}|", "CD", "NameCD", "SBH", "Price");
        line();
    }
    public static void line()
    {
        for (int i = 0; i < 60; i++)
        {
            System.Console.Write("-");
        }
        System.Console.WriteLine();
    }

    public int CompareTo(object? obj)
    {
        CD cd = obj as CD;
        return cd.price.CompareTo(price);
    }
}