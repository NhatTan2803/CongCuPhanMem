using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class GradeBook
    {
        private List<float> DanhSachDiem = new List<float>();
        public void Input (int amount)
        {
            float diemso;
            for (int i=0; i<amount; i++)
            {
                Console.Write("Nhap diem sinh vien thu "+ (i+1) +":");
                diemso = float.Parse(Console.ReadLine());
                DanhSachDiem.Add(diemso);
            }
        }

        public GradeStatistic TinhToanDiem()
        {
            GradeStatistic gradeStatistic = new GradeStatistic();

            float Tong = 0;

            foreach (float diemso in DanhSachDiem)
            {
                gradeStatistic.CaoNhat = Math.Max(diemso, gradeStatistic.CaoNhat);
                gradeStatistic.ThapNhat = Math.Min(diemso, gradeStatistic.ThapNhat);
                Tong += diemso;
            }

            gradeStatistic.TrungBinh = (DanhSachDiem.Count() > 0) ? Tong / DanhSachDiem.Count() : 0;

            return gradeStatistic;
        }

        public void ShowStatistic ()
        {
            GradeStatistic gradeStatistic = TinhToanDiem();
            Console.WriteLine("Cao nhat: {0}", gradeStatistic.CaoNhat);
            Console.WriteLine("Thap nhat: {0}", gradeStatistic.ThapNhat);
            Console.WriteLine("Trung binh: {0}", gradeStatistic.TrungBinh);
        }
    }
}
