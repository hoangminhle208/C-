using Project_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Station
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XeTai xt = new XeTai();
            XeKhach xk = new XeKhach();
            bool bol = true;
            while (bol)
            {
                Console.WriteLine("\n\tCHUONG TRINH QUAN LY BEN XE");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them xe tai.                                  **");
                Console.WriteLine("**  2. Them xe khach.                                **");
                Console.WriteLine("**  3. Cap nhat danh sach xe                         **");
                Console.WriteLine("**  4. Xoa xe theo bien so.                          **");
                Console.WriteLine("**  5. Tim kiem xe theo bien so.                     **");
                Console.WriteLine("**  6. Thong ke.                                     **");
                Console.WriteLine("**  7. Sap xep xe theo bien so .                     **");
                Console.WriteLine("**  8. Hien thi danh sach xe.                        **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("\tNhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n Them xe tai");
                        Console.WriteLine("\n Nhap so luong xe:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        xt.NhapNhieuXeTai(n);
                        Console.WriteLine("\nThem xe tai thanh cong!");
                        break;
                    case 2:
                        Console.WriteLine("\n Them xe khach");
                        Console.WriteLine("\n Nhap so luong xe:");
                        int k = Convert.ToInt32(Console.ReadLine());
                        xk.NhapNhieuXeKhach(k);
                        Console.WriteLine("\nThem xe khach thanh cong!");
                        break;
                    case 8:
                        Console.WriteLine("\n Hien thi danh sach xe");
                        xt.ShowXeTai();
                        xk.ShowXeKhach();
                        break;
                    default:
                        bol = false;
                        break;
                }
            }
        }
    }
}
