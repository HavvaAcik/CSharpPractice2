using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.Write(" Liütfen şifreyi giriniz.");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if(capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("sayıyı giriniz:");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result;
            //result = "hata";
            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine(average);

            //if(average>0 & average <= 50)
            //{
            //    result = "Sonuç çok kötü";
            //}
            //if(average >50 & average <= 70)
            //{
            //    result = "sonuç ortalama ";
            //}
            //if(average >70 & average <= 80)
            //{
            //    result = " sonuç iyi";
            //}
            //if (average > 80)
            //{
            //    result = " Sonuç harika. Tebrikss";
            //}

            //    Console.WriteLine(result);

            #endregion

            #region mod işlemleri 

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.Write("lütfen 1. sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1.sayının 2. sayının böümünden kalan :" + " "+ result);
            #endregion

            #region char değişkenleri ile karar yapıları 
            //char team;
            //Console.WriteLine("lütfen takım sembolünü giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g'|team == 'G')
            //{
            //    Console.WriteLine("galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("beşiktaş");
            //}



            #endregion

            #region örnek proje uygulaması 

            //Console.WriteLine("***** MENÜ *****");
            //Console.WriteLine();
            //Console.WriteLine("1- ÇORBALAR");
            //Console.WriteLine("2- ANA YEMEKLER");
            //Console.WriteLine("3- TATLILAR");

            //string item;
            //Console.WriteLine("Ayrıntısını görmek istediğiniz seçeneği yazınız.");
            //item = Console.ReadLine();
            //if (item == "1")
            //{
            //    Console.WriteLine("mercimek");
            //    Console.WriteLine("yayla");
            //}
            //if (item == "2")
            //{
            //    Console.WriteLine("köfte");
            //    Console.WriteLine("karnıyarık");
            //}
            //if (item == "3")
            //{
            //    Console.WriteLine("sütlaç");
            //    Console.WriteLine("güllaç");
            //}
            #endregion

            #region switch-case 

            //Console.WriteLine("Lütfenilk 6 ayından seçim yapınız.");
            //int months = int.Parse(Console.ReadLine());

            //switch (months)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    default: Console.WriteLine("hatalı giriş"); break;
            //}

            #endregion

            #region hesap makinesi

            //int number1;
            //int number2;
            //int result;
            //char symbol;
            //Console.Write("1. sayıyı giriniz:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz:");
            //number2 = int.Parse(Console.ReadLine()); 

            //Console.Write("yapmak istediğiniz işlemin sembolünü giriniz. * / + -");
            //symbol= char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("toplamı: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("farkı: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpımı: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölümü: " + result);
            //        break;
            //    default: Console.WriteLine("hatalı giriş"); break;


            //}

            #endregion


            Console.Read();
        }
    }
}
