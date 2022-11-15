using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom16_OOP
{
    abstract class Xe
    {
        private double tocDo;
        private string bienSo;
        private string hang;
        public static int soLuong;

        public double TocDo { get { return tocDo; } set { tocDo = value; } }
        public string Hang { get { return hang; } set { hang = value; }}
        public string BienSo { get { return bienSo; } set { bienSo = value; } }
        
        public Xe()
        {
            tocDo = 0;
            bienSo = "";
            hang = "";
        }
        public Xe(double tocDo,string bienSo,string hang)
        {
            TocDo = tocDo;
            BienSo = bienSo;
            Hang = hang;
        }
        public virtual void Nhap1Xe()
        {
            do
            {
                Console.WriteLine("Nhap toc do:");
                TocDo = double.Parse(Console.ReadLine());
            }
            while (TocDo < 0);
            Console.WriteLine("Nhap bien so:");
            BienSo=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap hang: ");
            Hang= Convert.ToString(Console.ReadLine());
        }
        public virtual void Xuat1Xe()
        {
            Console.WriteLine("Toc Do cua Xe:  {0} km/h", TocDo);
            Console.WriteLine("Bien So cua Xe:  {0}", BienSo);
            Console.WriteLine("Hang San Xuat cua Xe:  {0}", Hang);
        }
        public abstract int Dem();
        
    }
}
