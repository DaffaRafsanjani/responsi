using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawans karyawans = new karyawans(190302123, "Paijo", 3000000);
            Karyawans karyawans = new Karyawans(190302124, "joni", 2000000);


            Console.WriteLine("NIK \t Nama \t\t Gaji");
            Console.WriteLine("-------------------------------");
            karyawans.Karyawans();
            karyawans.Karyawans();

            Console.WriteLine(" Asyiiiiik kenaikan gaji 10!!");

            Console.WritweLine("NIK \t Nama \t\t Gaji");
            Console.WriteLine("-------------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }
}
