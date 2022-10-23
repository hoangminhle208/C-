using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOI_KY
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
                    case 4:
                        if (xt.SoLuongXeTai() > 0 || xk.SoLuongXeKhach() > 0)
                        {
                            string bS;
                            Console.WriteLine("\n 4. Xoa xe theo bien so:");
                            Console.WriteLine("\n nhap bien so :");
                            bS = Convert.ToString(Console.ReadLine());
                            if (xk.deleteByBienSo(bS) == true)
                            {
                                xk.ShowXeKhach();
                            }
                            if (xt.deleteByBienSo(bS) == true)
                            {
                                xt.ShowXeTai();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n danh sach xe trong");
                        }
                        break;
                    case 5:
                        string F;
                        Console.WriteLine("\n 5. Tim kiem xe theo bien so.");
                        Console.WriteLine("\n Nhap bien so xe can tim:");
                        F = Convert.ToString(Console.ReadLine());
                        if (xt.findBienSo(F) != null) xt.show1xetai(xt.findBienSo(F));
                        if (xk.findBienSo(F) != null) xk.show1xekhach(xk.findBienSo(F));
                        if ((xt.findBienSo(F) == null) && (xk.findBienSo(F) == null)) Console.WriteLine(" Khong co xe nay trong ben! ");
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
