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
        static void TaoDuLieuMau()
        {
            Xe xe1 = new XeTai(44,"aa","bb",54);
            listxetai.Add((XeTai)xe1);
            XeTai xt=new XeTai(50,"78d1234","huynhdai",55.1);
            listxetai.Add(xt);
            XeTai xt1 = new XeTai(40, "66d7899", "kia", 40);
            listxetai.Add(xt1);
            XeTai xt2 = new XeTai(45.12, "99d1a", "container", 123.2);
            listxetai.Add(xt2);
            XeTai xt3 = new XeTai(41.1151, "155aa4", "diem my", 1.235);
            listxetai.Add(xt3);
            XeKhach xk=new XeKhach(125.4, "44a4a4", "tuan dat", 10);
            listxekhach.Add(xk);
            XeKhach xk1 = new XeKhach(21.24, "5a5aaa", "chi hung", 30);
            listxekhach.Add(xk1);
            XeKhach xk2 = new XeKhach(125.4, "zzz54", "phuong chi",45);
            listxekhach.Add(xk2);
            XeKhach xk3 = new XeKhach(44.5, "7a8sa8", "minh hoang", 50);
            listxekhach.Add(xk3);
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
                Console.WriteLine("**  3. Xoa xe theo bien so.                          **");
                Console.WriteLine("**  4. Tim kiem tat ca xe .                          **");
                Console.WriteLine("**  5. Thong ke.                                     **");
                Console.WriteLine("**  6. Sua xe khach theo bien so.                    **");
                Console.WriteLine("**  7. Sua xe tai theo bien so.                      **");
                Console.WriteLine("**  8. Hien thi danh sach xe.                        **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("\tNhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n Them xe tai");
                        NhapListXeTai();
                        Console.WriteLine("\nThem xe tai thanh cong!");
                        break;
                    case 2:
                        Console.WriteLine("\n Them xe khach");
                        NhapListXeKhach();
                        Console.WriteLine("\nThem xe khach thanh cong!");
                        break;
                    case 3:
                        Console.WriteLine("Xoa xe theo bien so");
                        Delete();
                        break;
                    case 4:
                        Console.WriteLine("Tim kiem trong tat ca xe");
                        findAll();
                        break;
                    case 5:
                        Console.WriteLine("Thong ke");
                        Xe x = new XeTai();
                        x.ThongKe();
                        Console.WriteLine($"So xe tai hien tai: {listxetai.Count()}");
                        Xe y=new XeKhach();
                        y.ThongKe();
                        Console.Write($"So xe khach hien tai: {listxekhach.Count()}");
                        break;
                    case 6:
                        Console.WriteLine("Sua xe khach theo bien so");
                        SuaXeKhach();
                        break;
                    case 7:
                        Console.WriteLine("Sua xe tai theo bien so");
                        SuaXeTai();
                        break;
                    case 8:
                        Console.WriteLine("\n Hien thi danh sach xe");
                        Console.WriteLine("\n Danh sach xe tai");
                        DanhSachXeTai();
                        Console.WriteLine("\n Danh sach xe khach");
                        DanhSachXeKhach();
                        break;
                    default:
                        bol = false;
                        break;
                }
            }
        }
        //list xe tai
        static List<XeTai> listxetai = new List<XeTai>();
        //list xe khach
        static List<XeKhach> listxekhach = new List<XeKhach>();
        
        
        static void NhapListXeTai()
        {
            Console.Write("Nhap so xe tai: ");
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                XeTai x = new XeTai();
                x.Nhap1Xe();
                listxetai.Add(x);
                Console.WriteLine("-------------");
            }
        }
        //nhap xe khach va add vao list
        static void NhapListXeKhach()
        {
            Console.Write("Nhap so xe khach: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                XeKhach x = new XeKhach();
                x.Nhap1Xe();
                listxekhach.Add(x);
                Console.WriteLine("-------------");
            }
        }
        //bang xe tai
        static void DanhSachXeTai()
        {
            var table = new Table();
            table.SetHeaders("STT","Bien so", "Hang", "Toc do","Trong tai","Date");
            int i = 1;
            foreach(XeTai xt in listxetai)
            {
                table.AddRow(i.ToString(),xt.BienSo, xt.Hang, xt.TocDo.ToString(), xt.TrongTai.ToString(), DateTime.Now.ToLongDateString());
                i++;
            }
            Console.WriteLine(table.ToString());
        }
        //bang xe khach
        static void DanhSachXeKhach()
        {
            var table = new Table();
            table.SetHeaders("STT", "Bien so", "Hang", "Toc do", "So Ghe","Date");
            int i = 1;
            foreach (XeKhach xk in listxekhach)
            {
                table.AddRow(i.ToString(), xk.BienSo, xk.Hang, xk.TocDo.ToString(), xk.SoGhe.ToString(), DateTime.Now.ToLongDateString());
                i++;
            }
            Console.WriteLine(table.ToString());
        }
        //tim trong tat ca xe
        public static void findAll()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap 1 de tim theo bien so:");
                Console.WriteLine("Nhap 2 de tim theo toc do:");
                Console.WriteLine("Nhap 3 de tim theo hang:");
                Console.WriteLine("Nhap 4 de tim theo trong tai(Xe Tai):");
                Console.WriteLine("Nhap 5 de tim theo so ghe(Xe Khach):");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 && n > 5);
            if (n == 1)
            {
                Console.Write("nhap bien so:");
                string k=Convert.ToString(Console.ReadLine());
                var t_xetai=new Table();
                t_xetai.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai");
                var t_xekhach=new Table();
                t_xekhach.SetHeaders("Bien so", "Hang", "Toc do", "So Ghe");
                foreach (XeTai xt in listxetai)
                {
                    if(xt.BienSo.ToString() == k)
                    {
                        t_xetai.AddRow(xt.BienSo, xt.Hang, xt.TocDo.ToString(), xt.TrongTai.ToString());
                    }
                }
                foreach(XeKhach xk in listxekhach)
                {
                    if(xk.BienSo.ToString() == k)
                    {
                        t_xekhach.AddRow(xk.BienSo, xk.Hang, xk.TocDo.ToString(), xk.SoGhe.ToString());
                    }
                }
                Console.WriteLine("danh sach xe tai can tim");
                Console.WriteLine(t_xetai);
                Console.WriteLine("danh sach xe khach can tim");
                Console.WriteLine(t_xekhach);
            }
            if (n == 2)
            {
                Console.Write("nhap toc do:");
                double k = double.Parse(Console.ReadLine());
                var t_xetai = new Table();
                t_xetai.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai");
                var t_xekhach = new Table();
                t_xekhach.SetHeaders("Bien so", "Hang", "Toc do", "So Ghe");
                foreach (XeTai xt in listxetai)
                {
                    if (xt.TocDo == k)
                    {
                        t_xetai.AddRow(xt.BienSo, xt.Hang, xt.TocDo.ToString(), xt.TrongTai.ToString());
                    }
                }
                foreach (XeKhach xk in listxekhach)
                {
                    if (xk.TocDo == k)
                    {
                        t_xekhach.AddRow(xk.BienSo, xk.Hang, xk.TocDo.ToString(), xk.SoGhe.ToString());
                    }
                }
                Console.WriteLine("danh sach xe tai can tim");
                Console.WriteLine(t_xetai);
                Console.WriteLine("danh sach xe khach can tim");
                Console.WriteLine(t_xekhach);
            }
            if (n == 3)
            {
                Console.Write("nhap hang:");
                string k = Convert.ToString(Console.ReadLine());
                var t_xetai = new Table();
                t_xetai.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai");
                var t_xekhach = new Table();
                t_xekhach.SetHeaders("Bien so", "Hang", "Toc do", "So Ghe");
                foreach (XeTai xt in listxetai)
                {
                    if (xt.Hang.ToString() == k)
                    {
                        t_xetai.AddRow(xt.BienSo, xt.Hang, xt.TocDo.ToString(), xt.TrongTai.ToString());
                    }
                }
                foreach (XeKhach xk in listxekhach)
                {
                    if (xk.Hang.ToString() == k)
                    {
                        t_xekhach.AddRow(xk.BienSo, xk.Hang, xk.TocDo.ToString(), xk.SoGhe.ToString());
                    }
                }
                Console.WriteLine("danh sach xe tai can tim");
                Console.WriteLine(t_xetai);
                Console.WriteLine("danh sach xe khach can tim");
                Console.WriteLine(t_xekhach);
            }
            if (n == 4)
            {
                Console.Write("nhap trong tai:");
                double k = double.Parse(Console.ReadLine());
                var t_xetai = new Table();
                t_xetai.SetHeaders("Bien so", "Hang", "Toc do", "Trong tai");
                foreach (XeTai xt in listxetai)
                {
                    if (xt.TrongTai == k)
                    {
                        t_xetai.AddRow(xt.BienSo, xt.Hang, xt.TocDo.ToString(), xt.TrongTai.ToString());
                    }
                }
                Console.WriteLine("danh sach xe tai can tim");
                Console.WriteLine(t_xetai);
            }
            if(n==5)
            {
                Console.Write("nhap so ghe:");
                int k = int.Parse(Console.ReadLine());
                var t_xekhach = new Table();
                t_xekhach.SetHeaders("Bien so", "Hang", "Toc do", "So ghe");
                foreach (XeKhach xk in listxekhach)
                {
                    if (xk.SoGhe == k)
                    {
                        t_xekhach.AddRow(xk.BienSo, xk.Hang, xk.TocDo.ToString(), xk.SoGhe.ToString());
                    }
                }
                Console.WriteLine("danh sach xe tai can tim");
                Console.WriteLine(t_xekhach);
            }
        }
        public static void Delete()
        {
            Console.Write("nhap bien so:");
            string k = Convert.ToString(Console.ReadLine());

            listxetai.RemoveAll(l=>l.BienSo == k);

            listxekhach.RemoveAll(l=>l.BienSo==k);
            /**foreach (XeTai xt in listxetai.ToList())
            {
                if (xt.BienSo == k)
                {
                    listxetai.Remove(xt);
                }
            }
            foreach (XeKhach xk in listxekhach)
            {
                if (xk.BienSo == k)
                {
                    listxekhach.Remove(xk);
                }
            }**/
        }
        
        public static void SuaXeTai()
        {
            bool t=false;
            Console.Write("nhap bien so:");
            string k = Convert.ToString(Console.ReadLine());
            foreach (XeTai xt in listxetai)
            {
                if (xt.BienSo.ToString() == k)
                {
                    t = true;
                    Console.Write("nhap lai bien so moi:");
                    xt.BienSo = Convert.ToString(Console.ReadLine());
                    Console.Write("nhap lai hang moi:");
                    xt.Hang=Convert.ToString(Console.ReadLine());
                    Console.Write("nhap lai toc do :");
                    xt.TocDo=double.Parse(Console.ReadLine());
                    Console.Write("nhap lai trong tai:");
                    xt.TrongTai=double.Parse(Console.ReadLine());
                }
                else Console.WriteLine("khong tim thay xe tai");
            }
            if(t==true) Console.WriteLine("khong tim thay xe tai");
        }

        public static void SuaXeKhach()
        {
            bool t=false;
            Console.Write("nhap bien so:");
            string k = Convert.ToString(Console.ReadLine());
            foreach (XeKhach xk in listxekhach)
            {
                if (xk.BienSo.ToString() == k)
                {
                    t = true;
                    Console.Write("nhap lai bien so moi:");
                    xk.BienSo = Convert.ToString(Console.ReadLine());
                    Console.Write("nhap lai hang moi:");
                    xk.Hang = Convert.ToString(Console.ReadLine());
                    Console.Write("nhap lai toc do :");
                    xk.TocDo = double.Parse(Console.ReadLine());
                    Console.Write("nhap lai so ghe:");
                    xk.SoGhe = int.Parse(Console.ReadLine());
                }
                
            }
            if(t==true) Console.WriteLine("khong tim thay xe khach");
        }
    }
}
