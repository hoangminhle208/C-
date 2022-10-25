using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOI_KY
{
    internal class XeTai : Xe
    {
        //Fiedls
        private double trongTai;

        //Properties
        protected double TrongTai
        {
            get { return trongTai; }
            set { trongTai = value; }
        }

        //Constructor
        //public XeTai() { }

        //List xe tai
        private List<XeTai> ListXeTai = null;
        public XeTai()
        {
            ListXeTai = new List<XeTai>();
        }

        //Return so luong xe tai
        public int SoLuongXeTai()
        {
            int Count = 0;
            if (ListXeTai != null)
            {
                Count = ListXeTai.Count;
            }
            return Count;
        }

        //Nhap 1 xe tai
        public void Nhap1XeTai()
        {
            XeTai xeTai = new XeTai();
            Console.WriteLine("Nhap bien so: ");
            xeTai.BienSo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap hang xe: ");
            xeTai.Hang = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap hang toc do(km/h): ");
            xeTai.TocDo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap hang trong tai(tan): ");
            xeTai.TrongTai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------");

            ListXeTai.Add(xeTai);
        }
        //nhap nhieu xe tai
        public void NhapNhieuXeTai(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Nhap1XeTai();
            }
        }
        public void ShowXeTai()
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, 5} {1, 10} {2, 15} {3, 20} {4, 25} ",
                  "BIEN SO", "HANG", "TOC DO", "TRONG TAI", "SO GHE");
            // hien thi danh sach xe
            if (ListXeTai != null && ListXeTai.Count > 0)
            {
                foreach (XeTai xeTai in ListXeTai)
                {
                    Console.WriteLine("{0, 5} {1, 10} {2, 15} {3, 20} ",
                                      xeTai.BienSo, xeTai.Hang, xeTai.TocDo, xeTai.TrongTai);
                }
            }
            Console.WriteLine();
        }
        public void show1xetai(XeTai xt)
        {
            Console.WriteLine("{0, 5} {1, 10} {2, 15} {3, 20}{4, 25} ",
                 "BIEN SO", "HANG", "TOC DO", "TRONG TAI", "SO GHE");
            Console.WriteLine("{0, 5} {1, 10} {2, 15} {3, 20} ",
                                     xt.BienSo, xt.Hang, xt.TocDo, xt.TrongTai);
        }

        public XeTai findBienSo(string bienSo)
        {
            XeTai xe = null;
            if (ListXeTai != null && ListXeTai.Count > 0)
            {
                foreach (XeTai xt in ListXeTai)
                {
                    if (xt.BienSo == bienSo)
                    {
                        xe = xt;
                    }
                }
            }
            return xe;
        }
        public bool deleteByBienSo(string bienSo)
        {
            bool Isdeleted = false;
            XeTai xe = findBienSo(bienSo);
            if (xe != null)
            {
                Isdeleted = ListXeTai.Remove(xe);
            }
            return Isdeleted;

        }

    }

}
