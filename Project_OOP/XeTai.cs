using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Data;
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
        private static List<XeTai> ListXeTai = null;
        public XeTai()
        {
            ListXeTai = new List<XeTai>();
        }

        //Return so luong xe tai
        

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
        //tao bang hien thi
        public static DataTable DanhSachXeTai()
        {
            var dt = new DataTable();
            dt.Columns.Add("Biển số");
            dt.Columns.Add("Hãng");
            dt.Columns.Add("Tốc độ");
            dt.Columns.Add("Trọng Tải");
            foreach(XeTai xeTai in ListXeTai)
            {
                dt.Rows.Add(xeTai.BienSo,xeTai.Hang,xeTai.TocDo,xeTai.TrongTai);
            }
            return dt;
        }
        public static void Show()
        {
            Console.WriteLine("Danh sach xe tai\n");
            Console.OutputEncoding = Encoding.UTF8;
            var data = DanhSachXeTai();
            string[] columnNames = data.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();

            DataRow[] rows = data.Select();

            var table = new ConsoleTable(columnNames);
            foreach (DataRow row in rows)
            {
                table.AddRow(row.ItemArray);
            }
            //table.Write(Format.MarkDown);
            table.Write(Format.Alternative);
            //table.Write(Format.Minimal);
            //table.Write(Format.Default);
            //Console.Read();
        }

    }

}
