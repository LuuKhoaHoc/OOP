using System.Collections.Generic;
public class CDList
{
    List<CD> CDlist = new List<CD>();
    public void AddCD(int newcd, string newnamecd, int newsbh, float newprice)
    {
        bool check1 = false;
        foreach (var item in CDlist)
        {
            if (newcd == item.Cd)
            {
                check1 = true;
                break;
            }
        }
        if (check1 == false)
        {
            CDlist.Add(new CD(newcd, newnamecd, newsbh, newprice));
        }
    }
    public int CountCD()
    {
        return CDlist.Count;
    }
    public float PriceCD()
    {
        float sum = 0;
        foreach (var item in CDlist)
        {
            sum += item.Price;
        }
        return sum;
    }
    public void PrintCD()
    {
        CD.title();
        foreach (var item in CDlist)
        {
            System.Console.WriteLine(item);
        }
        CD.line();
    }
    public void SortCDbyPrice()
    {
        CDlist.Sort();
    }
    public void SortCDbyName()
    {
        CDlist.Sort(new SortbyNameCD());
    }

}