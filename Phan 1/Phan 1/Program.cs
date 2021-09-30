using System;
using System.Text;

namespace Phan_1
{
    class Program
    {
        // ______________________________BAI 1______________________________
        static void Bai1()
        {
            Console.Write(" Nhap ho ten: ");
            string HoTen = Console.ReadLine();
            Console.Write(" Nhap Ma So Sinh Vien: ");
            string Masosinhvien = Console.ReadLine();
            Console.Write(" Nhap Lop: ");
            string Lop = Console.ReadLine();
            Console.Write(" Nhap So dien thoai: ");
            string SoDienThoai = Console.ReadLine();
            Console.Write(" Nhap Gioi tinh: ");
            string Gioitinh = Console.ReadLine();
            Console.WriteLine(" Ho ten: " + HoTen);
            Console.WriteLine(" Ma so sinh vien: " + Masosinhvien);
            Console.WriteLine(" Lop: " + Lop);
            Console.WriteLine(" So dien thoai: " + SoDienThoai + " " + " Gioi tinh: " + Gioitinh);
            Console.ReadKey();
        }
        // ______________________________BAI 2______________________________
        static void Bai2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("            XUÂN VỀ             ");
            Console.WriteLine("Từng đàn con trẻ chạy xun xoe ");
            Console.WriteLine("Mưa lạnh, trời quang, nắng mới hoe ");
            Console.WriteLine("Lá nõn nhành non, ai tráng bạc? ");
            Console.WriteLine("Gió về từng tận, gió bay đi... ");
            Console.WriteLine("   Thong thả dân gian nghỉ việc đồng ");
            Console.WriteLine("   Lúa thì con gái mượt như nhung ");
            Console.WriteLine("   Đầy vươn hoa bưởi, hoa cam rụng ");
            Console.WriteLine("   Ngào ngạt hương bay, bướm vẽ vòng ");
            Console.WriteLine("Trên đường cát mịn, một đôi cô ");
            Console.WriteLine("Yếm đỏ, khăn thâm, trẩy hội chùa ");
            Console.WriteLine("Gậy trúc dắt bà già tóc bạc ");
            Console.WriteLine("Tay lần tràng hạt, miệng nam mô.");

            Console.ReadKey();
        }

        // ______________________________BAI 3______________________________
        static void Bai3()
        {
            Console.WriteLine("/*****************************************/");
            Console.WriteLine("/******* HUONG DAN CHEP TAP TIN *******/");
            Console.WriteLine("/=>B1. Vao thu muc “C:\\TUYENTAP\thotinh.txt”/");
            Console.WriteLine("/=>B2. Click chuot phai vao tap tin thotinh.txt      /");
            Console.WriteLine("/=>B3. Chon copy tu menu tat                                /");
            Console.WriteLine("/=>B4. Chon vi tri can luu, click phai chon paste  /");
            Console.WriteLine("/*****************************************/");


            Console.ReadKey();
        }

        // ______________________________BAI 4______________________________
        static void Bai4()
        {
            Console.WriteLine("/*****************************************/");
            Console.WriteLine("/******* HUONG DAN CHEP TAP TIN *******/");
            Console.WriteLine("/=>B1. Vao thu muc “C:\\TUYENTAP\thotinh.txt”/");
            Console.WriteLine("/=>B2. Click chuot phai vao tap tin thotinh.txt      /");
            Console.WriteLine("/=>B3. Chon copy tu menu tat                                /");
            Console.WriteLine("/=>B4. Chon vi tri can luu, click phai chon paste  /");
            Console.WriteLine("/*****************************************/");


            Console.ReadKey();
        }

        // ______________________________BAI 5______________________________
        static void Bai5()
        {
            int n, sum = 0, m;
            Console.Write("Nhap so nguyen n gom 2 chu so: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Tong = " + sum);
            Console.ReadKey();
        }

        // ______________________________BAI 6______________________________
        static void Bai6()
        {
            Console.Write("Nhap do F: ");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do C tuong ung la = {0}", Fahrenheit * 5 / 9 - 32 * 5 / 9);
            Console.ReadKey();
        }

        // ______________________________BAI 7______________________________
        static void Bai7()
        {
            Console.WriteLine("Nhap gio: ");
            int gio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap phut: ");
            int phut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap giay: ");
            int giay = Convert.ToInt32(Console.ReadLine());
            int v = (gio * 3600) + phut * 60;
            Console.WriteLine("Tong so giay= {0}", v + giay);
            Console.ReadKey();
        }

        // ______________________________BAI 8______________________________
        static void Bai8()
        {
            Console.WriteLine("Nhap so giay: ");
            int giay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gio= {0}", giay / 3600);
            giay = giay % 3600;
            Console.WriteLine("Phut= {0}", giay / 60);
            Console.WriteLine("Giay= {0}", giay % 60);
            Console.ReadKey();
        }

        // ______________________________BAI 9______________________________
        public static void Xuat(int a, int b)
        {
            Console.WriteLine("Tong cua 2 so la: {0}", tong(a, b));
            Console.WriteLine("Hieu cua 2 so la: {0}", hieu(a, b));
            Console.WriteLine("Tich cua 2 so la: {0}", tich(a, b));
            Console.WriteLine("Thuong cua 2 so la: {0}", thuong(a, b));
        }
        public static int tong(int a, int b)
        {
            return a + b;
        }
        public static int hieu(int a, int b)
        {
            return a - b;
        }
        public static int tich(int a, int b)
        {
            return a * b;
        }
        public static int thuong(int a, int b)
        {
            return a / b;
        }
        static void Bai9()
        {
            int a = 0; int b = 0;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Xuat(a, b);
            Console.ReadKey();
        }

        // ______________________________BAI 10______________________________
        public static double tbc(int a, int b, int c, int d)
        {
            return (a + b + c + d) / 4;
        }
        static void Bai10()
        {
            int a = 0; int b = 0; int c = 0; int d = 0;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Nhap d: ");
            d = int.Parse(Console.ReadLine());

            Console.Write("Gia tri trung binh cong la: {0}", tbc(a, b, c, d));

            Console.ReadKey();
        }
        

        // ______________________________BAI 11______________________________
        public static (int a, int b, int c) nhapTG(int a, int b, int c)
        {
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            (int a, int b, int c) p = (a, b, c);
            return p;
        }
        public static void xuatTG(int a, int b, int c)
        {
            Console.WriteLine("Dien tich tam giac la: {0}", areaTG(a, b, c));
            Console.WriteLine("Chu vi tam giac la: {0}", cirTG(a, b, c));
        }
        public static double areaTG(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double kq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return kq;
        }
        public static double cirTG(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int nhapHV(int a)
        {
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            int p = a;
            return p;
        }
        public static void xuatHV(int a)
        {
            Console.WriteLine("Dien tich hinh vuong la: {0}", areaHV(a));
            Console.WriteLine("Chu vi hinh vuong la: {0}", cirHV(a));
        }
        public static double areaHV(int a)
        {
            return a * a;
        }
        public static double cirHV(int a)
        {
            return 4 * a;
        }
        public static (int a, int b) nhapHCN(int a, int b)
        {
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            (int a, int b) p = (a, b);
            return p;
        }
        public static void xuatHCN(int a, int b)
        {
            Console.WriteLine("Dien tich hinh chu nhat la: {0}", areaHCN(a, b));
            Console.WriteLine("Chu vi hinh chu nhat la: {0}", cirHCN(a, b));
        }
        public static double areaHCN(int a, int b)
        {
            return a * b;
        }
        public static double cirHCN(int a, int b)
        {
            return (a + b) / 2;
        }
        public static int nhapHT(int r)
        {
            Console.Write("Nhap r: ");
            r = int.Parse(Console.ReadLine());
            int p = (r);
            return p;
        }
        public static void xuatHT(int r)
        {
            Console.WriteLine("Dien tich hinh tron la: {0}", areaHT(r));
            Console.WriteLine("Chu vi hinh tron la: {0}", cirHT(r));
        }
        public static double areaHT(int r)
        {
            return (r * r) * 3.14;
        }
        public static double cirHT(int r)
        {
            return (r * 2) * 3.14;
        }
        static void Bai11()
        {
            int a = 0; int b = 0; int c = 0; int r = 0;
            string n;
            Console.Write("Chon hinh (TG, HV, HCN): ");
            n = Console.ReadLine();
            if (n == "TG")
            {
                (a, b, c) = nhapTG(a, b, c);
                xuatTG(a, b, c);
            }
            if (n == "HV")
            {
                a = nhapHV(a);
                xuatHV(a);
            }
            if (n == "HCN")
            {
                (a, b) = nhapHCN(a, b);
                xuatHCN(a, b);
            }
            if (n == "HT")
            {
                r = nhapHT(r);
                xuatHT(r);
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Bai1();

            //Bai2();

            //Bai3();

            //Bai4();

            //Bai5();

            //Bai6();

            //Bai7();

            //Bai8();

            //Bai9();

            //Bai10();

            //Bai11();
        }
    }
}
