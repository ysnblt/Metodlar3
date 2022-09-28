using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medotlar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen sayının tek mi çift mi olduğunu yazdıran program
            Console.WriteLine("Bir sayı giriniz");
            int girilenDeger = Convert.ToInt32(Console.ReadLine());
            TekmiCiftmi(girilenDeger);
            Console.ReadLine();
        }

        static void TekmiCiftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }
    }

 
}
