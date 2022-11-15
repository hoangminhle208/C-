﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom16_OOP
{
    class XeKhach:Xe
    {
        private int soGhe;
        private static int soxk;

        public int SoGhe { get { return soGhe; } set { soGhe = value; } }

        public XeKhach():base()
        {
           SoGhe = 0;
        }

        public XeKhach(double tocDo, string bienSo, string hang,int soGhe) : base(tocDo, bienSo, hang)
        {
            SoGhe = soGhe;
        }
        public override void Nhap1Xe()
        {
            base.Nhap1Xe();
            do
            {
                Console.WriteLine("Nhap so ghe:");
                SoGhe = int.Parse(Console.ReadLine());
            } while(SoGhe < 0);
            soxk++;
        }
        public override void Xuat1Xe()
        {
            base.Xuat1Xe();
            Console.WriteLine("So ghe cua xe {0} ghe", SoGhe);
        }
        public override int Dem()
        {
            return soLuong++;
        }
    }
}
