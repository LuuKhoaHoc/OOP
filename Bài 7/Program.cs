Console.OutputEncoding = System.Text.Encoding.UTF8;
Hinhtron O = new Hinhtron(new Toado(5,5),10.5);
System.Console.WriteLine($"Hình tròn có tâm:{O.getTam()}");
System.Console.WriteLine($"Bán Kính R: {O.getBankinh()}");
System.Console.WriteLine($"Chu vi: {O.TinhChuVi()}");
System.Console.WriteLine($"Diện tích: {O.TinhDienTich()}");
