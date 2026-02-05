using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _02.variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkneler 
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("elmanın toplam fiyatı:" + appleTotalPrice);
            //Console.WriteLine("portakalın toplam fiyatı:" + orangeTotalPrice);
            //Console.WriteLine("çileğin toplam fiyatı:" + strawberryTotalPrice);
            //Console.WriteLine("patataesin toplam fiyatı:" + potatoTotalPrice);
            //Console.WriteLine("domatesin toplam fiyatı:" + tomatoTotalPrice);

            //Console.WriteLine("toplam tutar: " + appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice);

            #endregion

            #region char değişkenler 
            //// stringler "" tırnakla tanımlanırken caharlar '' tek tırnakla tanımlanırlar. 
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region klavyeden veri girişleri string değişkenler 
            //Console.WriteLine("**** A Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Bilgisi:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------------------------");

            //Console.WriteLine(
            //    "Kimlik bilgisi:" + " " + passengerIdentityNumber + " " +
            //    "Ad:" + " " + passengerName + " " +
            //    "Soyad:" + " " + passengerSurname + " " +
            //    "Yaş:" + " " + passengerAge + " " +
            //    "İl:" + " " + passengerCity + " " +
            //    "İlçe:" + " " + passengerDistrict);
            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler 

            //int shoesPrices, computerPrice, chairPrice, tvPrice;
            //shoesPrices = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //// int.Parse(), bir string (metin) ifadesini int (tam sayı) veri tipine dönüştürmek için kullanılan bir metottur.
            ////Özellikle kullanıcıdan alınan girdiler(Console.ReadLine veya TextBox verileri) her zaman string olarak gelir.
            ////Bu verilerle matematiksel işlemler yapabilmek için onları sayısal bir tipe çevirmeniz gerekir.
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrices + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("toplam ödemeniz gereken tutar:" + totalPrice);

            #endregion


            Console.Read();

        }
    }
}
