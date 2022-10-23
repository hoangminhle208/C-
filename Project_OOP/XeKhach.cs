using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOI_KY
{
    internal class XeKhach : Xe
    {

        //Fiedls
        private double soGhe;

        //Properties
        protected double SoGhe
        {
            get { return soGhe; }
            set { soGhe = value; }
        }

        //Constructor
        //public XeTai() { }

        //List xe tai
        private List<XeKhach> ListXeKhach = null;
        public XeKhach()
        {
            ListXeKhach = new List<XeKhach>();
        }

        //Return so luong xe khach
        public int SoLuongXeKhach()
        {
            int Count = 0;
            if (ListXeKhach != null)
            {
                Count = ListXeKhach.Count;
            }
            return Count;
        }
        //Nhap 1 xe khach

        public void Nhap1XeKhach()
        {
            XeKhach xeKhach = new XeKhach();
            Console.WriteLine("Nhap bien so: ");
            xeKhach.BienSo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap hang xe: ");
            xeKhach.Hang = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap hang toc do(km/h): ");
            xeKhach.TocDo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap hang so ghe: ");
            xeKhach.SoGhe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------");

            ListXeKhach.Add(xeKhach);
        }
        //nhap nhieu xe khach
        public void NhapNhieuXeKhach(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Nhap1XeKhach();
            }
        }
        //Hien thi danh sach xe khach
        public void ShowXeKhach()
        {
            // hien thi tieu de cot
            //Console.WriteLine("{0, 5} {1, 10} {2, 15} {3, 20} ",
            //"BIEN SO", "HANG", "TOC DO", "SO GHE");
            // hien thi danh sach xe
            if (ListXeKhach != null && ListXeKhach.Count > 0)
            {
                foreach (XeKhach xeKhach in ListXeKhach)
                {
                    //Console.WriteLine("{0, 5} {1, 10} {2, 15} {4, 25} ",
                    //xeKhach.BienSo, xeKhach.Hang, xeKhach.TocDo, xeKhach.SoGhe);
                    Console.WriteLine($"{xeKhach.BienSo,5}{xeKhach.Hang,10}{xeKhach.TocDo,15}{xeKhach.SoGhe,45}");
                }
            }
            Console.WriteLine();
        }
        public void show1xekhach(XeKhach xk)
        {
            Console.WriteLine("{0, 5} {1, 10} {2, 15} {3, 20}{4, 25} ",
                 "BIEN SO", "HANG", "TOC DO", "TRONG TAI", "SO GHE");
            Console.WriteLine($"{xk.BienSo,5}{xk.Hang,10}{xk.TocDo,15}{xk.SoGhe,45}");

        }
        public XeKhach findBienSo(string bienSo)
        {
            XeKhach xe = null;
            if (ListXeKhach != null && ListXeKhach.Count > 0)
            {
                foreach (XeKhach xk in ListXeKhach)
                {
                    if (xk.BienSo == bienSo)
                    {
                        xe = xk;
                    }
                }
            }
            return xe;
        }
        public bool deleteByBienSo(string bienSo)
        {
            bool Isdeleted = false;
            XeKhach xe = findBienSo(bienSo);
            if (xe != null)
            {
                Isdeleted = ListXeKhach.Remove(xe);
            }
            return Isdeleted;

        }
    }
}
