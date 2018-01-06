using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class TinhDiem
    {
        private List<float> DanhSachDiem = new List<float>();
        public void Input(int amount)
        {
            float diemso;
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Nhap diem sinh vien thu " + (i + 1) + ":");
                diemso = float.Parse(Console.ReadLine());
                DanhSachDiem.Add(diemso);
            }
        }

        public ThanhPhan TinhToanDiem()
        {
            ThanhPhan ThanhPhan = new ThanhPhan();

            float Tong = 0;

            foreach (float diemso in DanhSachDiem)
            {
                ThanhPhan.CaoNhat = Math.Max(diemso, ThanhPhan.CaoNhat);
                ThanhPhan.ThapNhat = Math.Min(diemso, ThanhPhan.ThapNhat);
                Tong += diemso;
            }

            ThanhPhan.TrungBinh = (DanhSachDiem.Count() > 0) ? Tong / DanhSachDiem.Count() : 0;

            return ThanhPhan;
        }

        public void ShowStatistic()
        {
            ThanhPhan ThanhPhan = TinhToanDiem();
            Console.WriteLine("Cao nhat: {0}", ThanhPhan.CaoNhat);
            Console.WriteLine("Thap nhat: {0}", ThanhPhan.ThapNhat);
            Console.WriteLine("Trung binh: {0}", ThanhPhan.TrungBinh);
        }
    }
}
