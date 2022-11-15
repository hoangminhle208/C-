using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom16_OOP
{
    class XeTai:Xe
    {
        private double trongTai;
        
        public double TrongTai { get { return trongTai; } set { trongTai = value; } }
        public XeTai():base()
        {
            trongTai = 0;
        }
        
        public XeTai(double tocDo,string bienSo,string hang,double trongTai) : base(tocDo, bienSo, hang)
        {
            TrongTai = trongTai;
        }

        public override void Nhap1Xe()
        {
            base.Nhap1Xe();
            do {
                Console.WriteLine("Nhap trong tai cua xe:");
                TrongTai = double.Parse(Console.ReadLine());
               }
            while (TrongTai < 0);
            
        }
        public override void Xuat1Xe()
        {
            base.Xuat1Xe();
            Console.WriteLine("Trong tai cua xe {0} tan",TrongTai);
        }
        public override int Dem()
        {
            return soLuong++;
        }
    }
}
