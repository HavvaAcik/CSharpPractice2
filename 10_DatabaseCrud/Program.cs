using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crud = create, read, update,delete

            #region kategori  ekleme işlemi 
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.Write("Eklemek istediğiniz kategori adı:");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FUSGT5A\\SQLEXPRESS;initial Catalog=CSharpEgitim;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori başarıyla eklendi");

            #endregion

            #region ürün ekleme işlemi 

            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.WriteLine("Ürün adı :");
            productName = Console.ReadLine();

            Console.WriteLine("Ürün fiyatı :");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FUSGT5A\\SQLEXPRESS;initial Catalog=CSharpEgitim;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values" +
                "(@p1,@p2,@p3)",connection);
            command.Parameters.AddWithValue("@p1", productName);
            command.Parameters.AddWithValue("@p2", productPrice);
            command.Parameters.AddWithValue("@p3", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Ürün eklemesi başarılı");

            #endregion
        }
    }
}
