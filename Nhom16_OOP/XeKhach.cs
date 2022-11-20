using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom16_OOP
{
    class XeKhach:Xe
    {
        //field
        private int soGhe;
        //property
        public int SoGhe { get { return soGhe; } set { soGhe = value; } }
        //constructor
        public XeKhach():base()
        {
            SoGhe = 0;
        }
        //constructor
        public XeKhach(double tocDo, string bienSo, string hang,int soGhe) : base(tocDo, bienSo, hang)
        {
            SoGhe = soGhe;
        }
        //ham nhap xe
        public override void Nhap1Xe()
        {
            base.Nhap1Xe();
            do
            {
                Console.Write("Nhap so ghe:");
                SoGhe = int.Parse(Console.ReadLine());
            } while(SoGhe < 0);
            soLuong++;
        }
        //ham xuat xe
        public override void Xuat1Xe()
        {
            base.Xuat1Xe();
            Console.WriteLine("So ghe cua xe {0} ghe", SoGhe);
        }
        public override int Dem()
        {
            return soLuong;
        }
        public override void ThongKe()
        {
            string k=$"So xe khach: {Dem()}";
            Console.WriteLine(k);
        }
        public override string XuatSoGhe()
        {
            return $"{SoGhe}";
        }
        public override string XuatTrongTai()
        {
            return "";
        }
    }
}
