using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1- void method

            // methodlarda mutlaka() olur. sol taraflarında mor renk küp bulunur. 
            // 2 tane  metod vardır
            // 1- geriye değer dödürmeyen metodlar void olarak tanımlanır. 
            // 2- geriye değer döndüren etodlar. 

            //void CustomerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("hakan öz");
            //    Console.WriteLine("merve çınar");
            //}
            //CustomerList(); // yazdığın metodu çalıştırmak için çağırman gerekir. 

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();


            #endregion

            #region 1.1- geriye değer döndürmeyen parametreli metodlar 

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("mehmet yıldırım");

            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri:" +name+" "+ surname);
            //}
            //customerCard("mehmet","yıldız");
            //customerCard("ayşe", "yıldız");

            #endregion

            #region 1.2- geriye değer döndürmeyen int metodlar 

            //void Sum(int x,int y,int z)
            //{
            //    int result = x + y + z;
            //    Console.WriteLine(result);
            //}
            //Sum(4,5,6);

            #endregion

            #region 2- geriye değer döndüren metodlar 
            ////buradaki metodlar void ile tanımlanmıyor. bir ınıfla değişken türüyle.... tanımlanıyor. 
            //string studentCard()
            //{
            //    string name = "ali";
            //    string surname = "yıldız";
            //    return name + " " + surname;

            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region 2.1- geriye değer döndüren parametreli metodlar

            string CountryCard(string countryName,string  capital,string flagColor)
            {
                string cardInfo = "Ülke: " + " " + countryName + "Başkent: " + capital + "Bayrak Rengi: " + flagColor;
                return cardInfo;

            }
            string x, y, z;
            Console.Write("Ülke adını giriniz");
            x = Console.ReadLine();
            Console.Write("Başkentin adını giriniz");
            y = Console.ReadLine();
            Console.Write("Bayrak rengini giriniz");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            #endregion
            Console.Read();
        }
    }
}
