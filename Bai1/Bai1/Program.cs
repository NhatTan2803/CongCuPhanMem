using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook app = new GradeBook();
            do
            {
                Console.WriteLine("1. Nhap diem: ");
                Console.WriteLine("2. Xem Thong Ke: ");
                int choose = Int32.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Console.WriteLine("Nhap so luong sinh vien: ");
                        int n = Int32.Parse(Console.ReadLine());
                        app.Input(n);
                        break;
                    case 2:
                        app.ShowStatistic();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
