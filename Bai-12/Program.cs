Khoahoc Csharp = new Khoahoc("C#", new DateOnly(2022,01,01), new DateOnly(2022,04,01));

Csharp.Themhocsinh(new Hocsinh("Ly Vi Phong", "112 TTV", 0835607205));
Csharp.Themhocsinh(new Hocsinh("Luu Khoa Hoc", "Binh Chanh", 123456789));
Csharp.Themhocsinh(new Hocsinh("Le Xuan Quang", "Phan Thiet", 058161685));
Csharp.Themhocsinh(new Hocsinh("Truc Tran", "Phan Thiet", 561606865));

Khoahoc Java = new Khoahoc("Java", new DateOnly(2022,02,01), new DateOnly(2022,05,01));

Java.Themhocsinh(new Hocsinh("Le Xuan Quang", "Phan Thiet", 058161685));
Java.Themhocsinh(new Hocsinh("Truc Tran", "Phan Thiet", 561606865));

Khoahoc Python = new Khoahoc("Python", new DateOnly(2022, 04, 28), new DateOnly(2023, 11, 12));

Python.Themhocsinh(new Hocsinh("Luu Khoa Hoc", "Binh Chanh", 123456789));
Python.Themhocsinh(new Hocsinh("Le Xuan Quang", "Phan Thiet", 058161685));

Danhsachkhoahoc dskhvtc = new Danhsachkhoahoc();
dskhvtc.ThemKhoaHoc(Csharp);
dskhvtc.ThemKhoaHoc(Java);
dskhvtc.ThemKhoaHoc(Python);

dskhvtc.DanhsachHVhocKH();

// dskhvtc.CacKHchuabatdau();
// dskhvtc.CacKHchuaketthuc();