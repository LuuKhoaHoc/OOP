using System.Collections;

public class SortbyNameCD : IComparer<CD>
{
    public int Compare(CD cd1, CD cd2)
    {
        return cd1.Namecd.CompareTo(cd2.Namecd);   
    }
}