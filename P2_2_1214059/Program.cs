using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== PT.FARHANRACHMANSYAH DJAYA ====");
            //Gaji Pokok
            Console.Write("Gaji Karyawan : Rp");
            int gajiKaryawan = int.Parse(Console.ReadLine());
            
            //Tunjangan
            int tunjangan = 20;
            int hasilTunjangan;
            int totalTunjangan = 100;

            hasilTunjangan = tunjangan * gajiKaryawan;
            totalTunjangan = hasilTunjangan / totalTunjangan;
            Console.WriteLine("Total Tunjangan 20% = Rp{0} ", totalTunjangan);
            
            //Bonus
            int bonus = 15;
            int hasilBonus;
            int totalBonus = 100;

            hasilBonus = bonus * gajiKaryawan;
            totalBonus = hasilBonus / totalBonus;
            Console.WriteLine("Total Bonus 15% = Rp{0}", totalBonus);

            //PPH
            int PPH = 35;
            int penjumlahanPPH;
            int totalPPH = 1000;

            penjumlahanPPH = PPH * gajiKaryawan;
            totalPPH = penjumlahanPPH / totalPPH;
            Console.WriteLine("PPH dari 3,5% = Rp{0}", totalPPH);

            //Total Gaji
            int totalGaji = gajiKaryawan + totalTunjangan + totalBonus;
            Console.WriteLine("Total Gaji yang di dapatkan Rp{0}", totalGaji );

            //Gaji Bersih
            int gajiBersih = totalGaji - totalPPH;
            Console.WriteLine("Gaji Bersih yang di dapatkan Rp{0}", gajiBersih);
        }
    }
}
