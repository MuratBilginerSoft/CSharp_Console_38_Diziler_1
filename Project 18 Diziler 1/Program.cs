using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_18_Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ÖğrenciAd = new string[3];
            int[] ÖğrenciNo = new int[3];
            char[] Cinsiyet = new char[3];

            //string[] ÖğrenciSoyad = new string[] { "Murat", "Büşra", "Nurdilek"};
            //string[] ÖğrenciSoyad2 = new string[3] { "Murat", "Büşra","Nurdilek" };

            for (int i = 0; i < ÖğrenciNo.Length; i++)
            {
                Console.Write((i + 1) + ". Öğrencinin Adını Giriniz:");
                ÖğrenciAd[i] = Console.ReadLine();
                Console.WriteLine();
                Console.Write((i + 1) + ". Öğrencinin Numarasını Giriniz:");
                ÖğrenciNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write((i + 1) + ". Öğrencinin Cinsiyetini Giriniz:");
                Cinsiyet[i] = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine();
            }

            for (int i = 0; i < ÖğrenciAd.Length; i++)
            {
                Console.WriteLine((i + 1) + ". Öğrencinin Adı:{0}\nÖğrenci No:{1}\nCinsiyeti:{2}", ÖğrenciAd[i], ÖğrenciNo[i], Cinsiyet[i]);

                Console.WriteLine();
            }

            int[] Sayılar = new int[10];
            string[] Kelime = new string[10];

            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
                Console.WriteLine(Kelime[i]);
            }

            Console.ReadKey();

        }
    }
}
