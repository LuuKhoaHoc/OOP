
public class CNList
{
    
    List<CongNhan> cnlist = new List<CongNhan>();
    public void AddCN(int newmCN, string mHo, string mTen, int mSoSP){
        cnlist.Add(new CongNhan(newmCN,mHo,mTen,mSoSP));
    }
    public void PrintCN(){
        CongNhan.title();
        foreach (var item in cnlist)
        {
            System.Console.WriteLine(item);
        }
        CongNhan.line();
    }
    public int CountCN(){
        return cnlist.Count;
    }
    public void PrintCN200(){
        CongNhan.title();
        foreach (var item in cnlist)
        {
            if (item.MSoSP > 200)
            {
                System.Console.WriteLine(item);
            }
        }
        CongNhan.line();
    }
    public void SortCNbySoSP(){
        cnlist.Sort();
    }
}