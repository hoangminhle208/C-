using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    abstract class Xe
    {
        //Fields
        private double tocDo;
        private string bienSo;
        private string hang;
        private int soLuong;

        //Properties
        protected double TocDo
        {
            get { return tocDo; }
            set { tocDo = value; }
        }
        protected string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }

        protected string Hang
        {
            get { return hang; }
            set { hang = value; }
        }

        protected int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        //Constructor
        protected Xe()
        {
            TocDo = 0;
            BienSo = "";
            Hang = "";
            SoLuong = 0;
        }
        //protected void Nhap();
        
    }
}
