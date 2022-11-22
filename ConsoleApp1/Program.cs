using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { //GİRİLEN SAYI KADAR İSİM YAZAN PROGRAM
            Console.WriteLine("İsim Giriniz");
            string isim = (Console.ReadLine());
            Console.WriteLine("Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine(isim);
            }





            //HESAPLAMA PROGRAMI
            Console.WriteLine("1.Sayı Giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" İşlem Seçiniz");
           string islem=(Console.ReadLine());      
            
            if (islem == "+")
            {
                Console.WriteLine(sayi1 + sayi2);
            }
            else if (islem == "-")
            {
                Console.WriteLine(sayi1 - sayi2);
            } 
            else if (islem == "*")
            {
                Console.WriteLine(sayi1 * sayi2);
            }
            else if (islem == "/")
            {
                Console.WriteLine(sayi1 / sayi2);
            }

            //İÇ AÇI HESAPLAMA
            Console.WriteLine("1. İç Açıyı Giriniz");
            int icaci1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. İç Açıyı Giriniz");
            int icaci2 = Convert.ToInt32(Console.ReadLine());
            
            int islemm = (icaci1 + icaci2-(180)) ;
            Console.WriteLine(islemm);  












            Console.ReadKey();



            
        }
    }
}
