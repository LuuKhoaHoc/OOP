Console.OutputEncoding = System.Text.Encoding.UTF8;

BooKLisT lisT = new BooKLisT();

lisT.ThemsacH(new SachGiaoKhoa("SGK10",new DateOnly(2003,12,01),300,"Kim Dong",50,"Cu")); 
lisT.ThemsacH(new SachGiaoKhoa("SGK11",new DateOnly(2003,12,02),700,"Kim Dong",60,"Moi"));
lisT.ThemsacH(new SachGiaoKhoa("SGK12",new DateOnly(2003,12,04),300,"Kim Dong",20,"Cu"));

lisT.ThemsacH(new SachThamKhao("STKNguVan",new DateOnly(2005,6,17),1000,"Thep Moi",20,150));
lisT.ThemsacH(new SachThamKhao("STKTiengAnh",new DateOnly(2005,6,18),1200,"Thep Moi",30,200));
lisT.ThemsacH(new SachThamKhao("STKTiengTrung",new DateOnly(2005,6,19),1500,"Thep Moi",50,200));

System.Console.WriteLine("Tổng thành tiền của sách giáo khoa là: "+lisT.TinhtongtienSGK());
System.Console.WriteLine("Tổng thành tiền của sách tham khảo là: "+lisT.TinhtongtienSTK());
System.Console.WriteLine("Trung bình cộng của sách tham khảo là: "+lisT.TbcSTK());

lisT.Xuatthongtin();





