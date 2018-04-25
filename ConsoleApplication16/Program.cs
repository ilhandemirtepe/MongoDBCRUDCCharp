using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductDAO dao = new ProductDAO();

            dao.DeleteTekli(null);
            //List<Product> p234 =dao. SortAndLimit("adi14900");


            //if (p234.Count>0)
            //{
            //    foreach (var item in p234)
            //    {
            //        Console.WriteLine(item.Name + "---" + item.Date);
            //    }
            //}
           
            //bool c = dao.isexist("selam");
            //Console.WriteLine("Hepsi Gelsin gelsin");
            //dao.FindOne("5063114bd386d8fadbd6b123");
            //Console.WriteLine("/////////////////////////////////");
            //Console.WriteLine("bir tane gelsin");

            //dao.FindOne("5ad88bcd21d42d1c7450cc7c");
            //Console.WriteLine("/////////////////////////////////");
            //Console.WriteLine("true olanlar gelsin");

            //dao.Condition(true);
            //Console.WriteLine("/////////////////////////////////");
            //Console.WriteLine("fiyat 4-20 arası olanlar gelsin");
            //dao.Condition2(4,20);

            //Console.WriteLine("/////////////////////////////////");
            //Console.WriteLine("kelimeyi içerenler  gelsin");
            //dao.Condition3("gel");

            //Console.WriteLine("/////////////////////////////////");
            //Console.WriteLine("Toplam urun sayısı gelsin");
            //dao.Sum();
            //Console.WriteLine("/////////////////////////////////");
            // Console.WriteLine("Bir tane ekledim");
            // dao.Create();


            //dao.UpdateOrInsert("adi1");
            //dao.UpdateOrInsert("adi123");
            //bool x = dao.isexist("adi1");
            //bool y = dao.isexist("");
            // dao.Delete("5063114bd386d8fadbd6b004");


            Console.ReadKey();         
        }
    }
   
}
