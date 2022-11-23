using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTable;
namespace Nhom16_OOP
{
    internal class Program
    {  
        /* Danh sach thanh vien
         * 20161317 - Le Minh Hoang
         * 21110478 - Do Chi Hung
         * 21110419 - Nguyen Tran Tuan Dat
         * 21110549 - Nguyen Thuy Diem My
         */
        static void TaoDuLieuMau() // tao du lieu mau de bo qua buoc nhap cho nhanh
        {
            Xe xe1 = new XeTai(44,"aa","bb",54);
            listxe.Add(xe1);
            Xe xt=new XeTai(50,"78d1234","huynhdai",55.1);
            listxe.Add(xt);
            Xe xt1 = new XeTai(40, "66d7899", "kia", 40);
            listxe.Add(xt1);
            Xe xt2 = new XeTai(45.12, "99d1a", "container", 123.2);
            listxe.Add(xt2);
            Xe xt3 = new XeTai(41.1151, "155aa4", "diem my", 1.235);
            listxe.Add(xt3);
            Xe xk=new XeKhach(125.4, "44a4a4", "tuan dat", 10);
            listxe.Add(xk);
            Xe xk1 = new XeKhach(21.24, "5a5aaa", "chi hung", 30);
            listxe.Add(xk1);
            Xe xk2 = new XeKhach(125.4, "zzz54", "phuong chi",45);
            listxe.Add(xk2);
            Xe xk3 = new XeKhach(44.5, "7a8sa8", "minh hoang", 50);
            listxe.Add(xk3);
        }
        static void Main(string[] args)
        {
            TaoDuLieuMau();
            bool bol = true;
            while (bol)
            {
                Console.WriteLine("\n\tCHUONG TRINH QUAN LY BEN XE");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them xe tai.                                  **");
                Console.WriteLine("**  2. Them xe khach.                                **");
                Console.WriteLine("**  3. Xoa xe.                                       **");
                Console.WriteLine("**  4. Tim kiem tat ca xe .                          **");
                Console.WriteLine("**  5. Thong ke.                                     **");
                Console.WriteLine("**  6. Sua xe theo bien so.                          **");
                Console.WriteLine("**  7. Hien thi danh sach xe.                        **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("\tNhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n Them xe tai");
                        NhapXeTai();
                        Console.WriteLine("\nThem xe tai thanh cong!");
                        break;
                    case 2:
                        Console.WriteLine("\n Them xe khach");
                        NhapXeKhach();
                        Console.WriteLine("\nThem xe khach thanh cong!");
                        break;
                    case 3:
                        Console.WriteLine("\n Xoa xe theo bien so");
                        Delete();
                        break;
                    case 4:
                        Console.WriteLine("\n Tim kiem trong tat ca xe");
                        TimKiem();
                        break;
                    case 5:
                        Console.WriteLine("\n Thong ke");
                        Console.WriteLine($"\n So xe hien tai: {listxe.Count()}");
                        Console.WriteLine($"\n So xe khach:{XeKhach.SoLuongXeKhach}");
                        Console.WriteLine($"\n So xe tai:{XeTai.SoLuongXeTai}");
                        break;
                    case 6:
                        Console.WriteLine("\n Sua xe theo bien so");
                        SuaXe();
                        break;
                    case 7:
                        Console.WriteLine("\n Hien thi danh sach xe");
                        Console.WriteLine("\n Danh sach xe");
                        DanhSachXe();
                        break;
                    default:
                        bol = false;
                        break;
                }
            }
        }
        //list xe 
        static List<Xe> listxe = new List<Xe>();
        //ham nhap xe tai va add vao list
        static void NhapXeTai()
        {
            Console.Write("Nhap so xe tai: ");
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Xe x = new XeTai();
                x.Nhap1Xe();
                listxe.Add(x);
                Console.WriteLine("-------------");
            }
        }
        //nhap xe khach va add vao list
        static void NhapXeKhach()
        {
            Console.Write("Nhap so xe khach: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Xe x = new XeKhach();
                x.Nhap1Xe();
                listxe.Add(x);
                Console.WriteLine("-------------");
            }
        }
        //hien thi danh sach xe 
        static void DanhSachXe()
        {
            var table = new Table();
            table.SetHeaders("STT","Bien so", "Hang", "Toc do","Trong tai","So ghe","Date");
            int i = 1;
            foreach(Xe x in listxe)
            {
                table.AddRow(i.ToString(),x.BienSo, x.Hang, x.TocDo.ToString(),x.XuatTrongTai(),x.XuatSoGhe(), DateTime.Now.ToLongDateString());
                i++;
            }
            Console.WriteLine(table.ToString());
        }
        
        //tim theo dieu kien tat ca xe
        public static void TimKiem()
        {
            int n;
            do
            {
                Console.WriteLine("1. Tim theo bien so:");
                Console.WriteLine("2. Tim theo toc do:");
                Console.WriteLine("3. Tim theo hang:");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 && n > 5);
            if (n == 1)
            {
                Console.Write("\nNhap bien so:");
                string k=Convert.ToString(Console.ReadLine());
                var t=new Table();
                t.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai","So ghe");
                foreach (Xe x in listxe)
                {
                    if(x.BienSo.ToString() == k)
                    {
                        t.AddRow(x.BienSo, x.Hang, x.TocDo.ToString(), x.XuatTrongTai(),x.XuatSoGhe());
                    }
                }
                Console.WriteLine("Danh sach xe can tim");
                Console.WriteLine(t);
            }
            if (n == 2)
            {
                Console.Write("\nNhap toc do:");
                double k = double.Parse(Console.ReadLine());
                var t = new Table();
                t.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai","So ghe");
                foreach (Xe x in listxe)
                {
                    if (x.TocDo == k)
                    {
                        t.AddRow(x.BienSo, x.Hang, x.TocDo.ToString(), x.XuatTrongTai(),x.XuatSoGhe());
                    }
                }

                Console.WriteLine("Danh sach xe can tim");
                Console.WriteLine(t);
            }
            if (n == 3)
            {
                Console.Write("\nNhap hang:");
                string k = Convert.ToString(Console.ReadLine());
                var t = new Table();
                t.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai","So ghe");
                foreach (Xe x in listxe)
                {
                    if (x.Hang.ToString().ToUpper() == k.ToUpper())
                    {
                        t.AddRow(x.BienSo, x.Hang, x.TocDo.ToString(), x.XuatTrongTai(),x.XuatSoGhe());
                    }
                }
                Console.WriteLine("Danh sach xe can tim");
                Console.WriteLine(t);
            }
        }
        //xoa xe theo yeu cau
        public static void Delete()
        {
            Console.WriteLine("1. Xoa theo bien so");
            Console.WriteLine("2. Xoa theo toc do");
            Console.WriteLine("3. Xoa theo hang");
            int k=int.Parse(Console.ReadLine());
            if (k == 1)
            {
                Console.Write("Nhap bien so:");
                string t = Convert.ToString(Console.ReadLine());
                bool z = false;
                foreach(Xe x in listxe)
                {
                    if(x.BienSo.ToString() == t)
                    {
                        z = true;
                        if (x.XuatSoGhe() == "")
                            XeTai.SoLuongXeTai--;
                        else
                            XeKhach.SoLuongXeKhach--;
                    }    
                }
                listxe.RemoveAll(l => l.BienSo == t);
                if (z== true)
                    Console.WriteLine("\nXoa xe thanh cong!");
                else
                    Console.WriteLine("\nXoa xe khong thanh cong");

            }
            if(k == 2)
            {
                Console.WriteLine("Nhap toc do");
                double a=double.Parse(Console.ReadLine());
                bool b=false;
                foreach(Xe x in listxe)
                {
                    if(x.TocDo== a)
                    {
                        b = true;
                        if (x.XuatSoGhe() == "")
                            XeTai.SoLuongXeTai--;
                        else
                            XeKhach.SoLuongXeKhach--;
                    }
                }
                listxe.RemoveAll(l => l.TocDo == a);
                if (b== true)
                    Console.WriteLine("\nXoa xe thanh cong!");
                else
                    Console.WriteLine("\nXoa xe khong thanh cong");
            }
            if (k == 3)
            {
                Console.Write("Nhap hang:");
                string t = Convert.ToString(Console.ReadLine());
                bool z = false;
                foreach(Xe x in listxe)
                {
                    if (x.Hang == t)
                    {
                        z=true;
                        if (x.XuatSoGhe() == "")
                            XeTai.SoLuongXeTai--;
                        else
                            XeKhach.SoLuongXeKhach--;
                    }
                }
                listxe.RemoveAll(l => l.Hang == t);
                if (z== true)
                    Console.WriteLine("\nXoa xe thanh cong!");
                else
                    Console.WriteLine("\nXoa xe khong thanh cong");

            }

        }
        //sua thong tin theo bien so
        public static void SuaXe()
        {
            bool t = false;
            Console.Write("Nhap bien so:");
            string k = Convert.ToString(Console.ReadLine());
            foreach (Xe xt in listxe)
            {
                if (xt.BienSo.ToString() == k)
                {
                    t = true;
                    Console.Write("Nhap lai bien so moi:");
                    xt.BienSo = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap lai hang moi:");
                    xt.Hang=Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap lai toc do :");
                    xt.TocDo=double.Parse(Console.ReadLine());
                }
            }
            if(t==false) Console.WriteLine("\nKhong tim thay xe!");
        }

        
    }
}
