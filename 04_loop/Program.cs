using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü

            //For(x;y;z;)
            // x: başlangıç
            // y: bitiş 
            // z: artış ya da azalış 

            //int i;
            //for ( i = 1; i<=5; i++)
            //{
            //    Console.WriteLine("yazı");
            //}

            // bir bakteri her saat sonu 2 katına çıkıyor. her bakteri de saat sonucu 2 ye çoğalıyor.
            // 24 saat sonra kaç bakteri olur 

            //int bacterium =1;
            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+ ". saat soyunda " + bacterium + " oluştu.");

            //}

            #endregion

            #region while döngüsü 

            // while(şart)
            //{
            //    işlemler 
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}



            #endregion

            #region örnek soru 

            //// klavyeden girilen 3 basamaklı sayının basamaklarının toplamını hesaplayan kod 

            //Console.WriteLine("3 basamaklı bir sayı giriniz.");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100; 
            //tens = (number % 100)/10;
            //Console.WriteLine(ones+"-"+tens+"-"+hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine("basamaktaki sayıların toplamı:" +sum);
            

            #endregion
        }
    }
}
