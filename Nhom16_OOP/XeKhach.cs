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
        private static int soLuongXeKhach=0;
        //property
        public int SoGhe { get { return soGhe; } set { soGhe = value; } }
        public static int SoLuongXeKhach { get { return soLuongXeKhach; } set { soLuongXeKhach = value;} }
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
            SoLuongXeKhach++;
        }
        //ham xuat xe
        public override void Xuat1Xe()
        {
            base.Xuat1Xe();
            Console.WriteLine("So ghe cua xe {0} ghe", SoGhe);
        }
        //ghi de ham ao 
        public override int Dem()
        {
            return SoLuongXeKhach;
        }
        //ghi de ham ao
        public override void ThongKe()
        {
            string k=$"So xe khach: {Dem()}";
            Console.WriteLine(k);
        }
        //ghi de ham ao
        public override string XuatSoGhe()
        {
            return $"{SoGhe}";
        }
        //ghi de ham ao
        public override string XuatTrongTai()
        {
            return "";
        }
    }
}
