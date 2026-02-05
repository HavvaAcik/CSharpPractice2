using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri

            //// DeğişkenTürü [] DiziAdı = new DeğişkennTürü[ElemanSayısı]
            //string[] colors = new String[4];
            //colors[0] = "red";
            //colors[1] = "black";
            //colors[2] = "yellow";
            //colors[3] = "blue";
            //Console.WriteLine(colors[2]);

            //string[] city = new string[5];
            //city[0] = "milano";
            //city[1] = "istanbul";
            //city[2] = "paris";
            //city[3] = "budapeşte";
            //city[4] = "lyon";

            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i=0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 4, 85, 466, 98, 777, 654, 682, 123,999,33 };
            //for(int i=0; i < number.Length; i++)
            //{
            //    if (number[i] %3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //int[] myArray = { 47, 88, 12, 34, 87, 90 };
            //int maxNumber = myArray[0];
            //for(int i =0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region dizi metodları 

            //// dizinin uzunluğunun hesaplanması 
            //string[] harf = { "a", "b", "c", "d" };
            //Console.WriteLine(harf.Length);

            //// diziyi küçükten büyüğe sırlamak için sort kullanılır.
            //int[] numbers = { 45, 85, 77, 23, 32 };
            //Array.Sort(numbers);
            //for (int i =1; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region dizi notları 

            //// Dizi tanımlama
            //int[] sayilar = { 10, 20, 30, 40, 50 };

            //// Index mantığı (0’dan başlar)
            //Console.WriteLine(sayilar[0]); // 10
            //Console.WriteLine(sayilar[3]); // 40

            //// Length: eleman sayısı
            //Console.WriteLine(sayilar.Length);

            //// for ile dizi gezme
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //// foreach ile dizi gezme
            //foreach (int s in sayilar)
            //{
            //    Console.WriteLine(s);
            //}

            //// ---------------- Array Özellik / Metodları ----------------

            //// IndexOf: elemanın index numarasını verir
            //int index = Array.IndexOf(sayilar, 30);
            //Console.WriteLine(index); // 2

            //// Exists: dizide eleman var mı kontrol eder
            //bool varMi = Array.Exists(sayilar, x => x == 40);
            //Console.WriteLine(varMi); // true

            //// Find: şarta uyan ilk elemanı getirir
            //int bulunan = Array.Find(sayilar, x => x > 25);
            //Console.WriteLine(bulunan); // 30

            //// FindAll: şarta uyan tüm elemanları getirir
            //int[] buyukler = Array.FindAll(sayilar, x => x >= 30);
            //foreach (int b in buyukler)
            //{
            //    Console.WriteLine(b);
            //}

            //// Sort: sıralama
            //Array.Sort(sayilar);

            //// Reverse: ters çevirme
            //Array.Reverse(sayilar);

            //// Copy: dizi kopyalama
            //int[] kopya = new int[sayilar.Length];
            //Array.Copy(sayilar, kopya, sayilar.Length);

            //// Clear: elemanları sıfırlar
            //Array.Clear(kopya, 0, kopya.Length);

            //// ---------------- Kısa Uygulama ----------------

            //// Toplam ve ortalama
            //int toplam = 0;
            //foreach (int s in sayilar)
            //{
            //    toplam += s;
            //}
            //double ortalama = (double)toplam / sayilar.Length;
            //Console.WriteLine(ortalama);

            //// Çok boyutlu dizi
            //int[,] tablo =
            //{
            //    {1, 2, 3},
            //    {4, 5, 6}
            //};
            //Console.WriteLine(tablo[1, 2]); // 6

            //Console.ReadLine();

            #endregion
        }
    }
}
