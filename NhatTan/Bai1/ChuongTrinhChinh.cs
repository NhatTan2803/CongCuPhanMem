using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class ChuongTrinhChinh
    {
        static void Main(string[] args)
        {
            TinhDiem app = new TinhDiem();
            do
            {
                        Console.WriteLine("----------Nhap Diem------------");
                        Console.WriteLine("Nhap so luong sinh vien: ");
                        int n = Int32.Parse(Console.ReadLine());
                        app.Input(n);
                        Console.WriteLine("-----------Thong Ke-----------");
                        app.ShowStatistic();
                
            } while (true);
        }
    }
}
