using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public class ProductDAO
    {

        private IMongoCollection<Product> productCollection;
        public ProductDAO()
        {
         
            MyContext.MyContext1();       
            productCollection =MyContext.database.GetCollection<Product>("product");
        }
       
        public void FindAll()
        {
            var product = productCollection.AsQueryable<Product>().ToList();
            foreach (var item in product)
            {
                Console.WriteLine("id:" + item.Id);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("price:" + item.Price);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("status:" + item.Status);
                Console.WriteLine("date:" + item.Date.ToShortDateString());
                Console.WriteLine("--------");
            }
        }


        public List<Product> SortAndLimit(string name)
        {
            List<Product> p1  = productCollection.AsQueryable<Product>().Where(x=>x.Name==name).OrderBy(p => p.Date).Take(1).ToList();
            return p1;
        }


        public bool isexist(string productName)
        {
           var  x1 = productCollection.AsQueryable<Product>().FirstOrDefault(x=>x.Name== productName);

       
            if (x1!=null)
            {
                string deneme = x1.Name;
                return true;
            }
            return false;
        }


        public void FindOne(string id)
        {
            var productid = new ObjectId(id);
            var product = productCollection.AsQueryable<Product>().SingleOrDefault(x => x.Id == productid);

            Console.WriteLine("id:" + product.Id);
            Console.WriteLine("name:" + product.Name);
            Console.WriteLine("price:" + product.Price);
            Console.WriteLine("name:" + product.Name);
            Console.WriteLine("status:" + product.Status);
            Console.WriteLine("date:" + product.Date.ToShortDateString());


        }


        public void Condition(bool status)
        {
            var product = productCollection.AsQueryable<Product>().Where(p => p.Status == status).ToList();
            foreach (var item in product)
            {
                Console.WriteLine("id:" + item.Id);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("price:" + item.Price);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("status:" + item.Status);
                Console.WriteLine("date:" + item.Date.ToShortDateString());
                Console.WriteLine("......................");
            }

        }




        public void Condition2(double min, double max)
        {
            var product = productCollection.AsQueryable<Product>().Where(p => p.Price >= min && p.Price <= max).ToList();
            foreach (var item in product)
            {
                Console.WriteLine("id:" + item.Id);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("price:" + item.Price);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("status:" + item.Status);
                Console.WriteLine("date:" + item.Date.ToShortDateString());
                Console.WriteLine("......................");
            }

        }


        public void Condition3(string kelime)
        {
            var product = productCollection.AsQueryable<Product>().Where(p => p.Name.Contains(kelime)).ToList();
            foreach (var item in product)
            {
                Console.WriteLine("id:" + item.Id);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("price:" + item.Price);
                Console.WriteLine("name:" + item.Name);
                Console.WriteLine("status:" + item.Status);
                Console.WriteLine("date:" + item.Date.ToShortDateString());
                Console.WriteLine("......................");
            }

        }

        public void Sum()
        {
            var product = productCollection.AsQueryable<Product>().Sum(p => p.Quantity);
            Console.WriteLine("urun sayısı=" + product);
        }


        public void Create()
        {
            Product p = new Product
            {
                Name="adi1",
                Date=DateTime.Now,
                Price=123,
                Quantity=909,
                Status=false,

            };
            productCollection.InsertOne(p);
        }

        public void UpdateOrInsert(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var product = productCollection.AsQueryable<Product>().SingleOrDefault(x => x.Name == name);
                if (product==null)
                {
                    Product p = new Product
                    {
                        Name =name,
                        Date = DateTime.Now,
                        Price = 123,
                        Quantity = 909,
                        Status = false,

                    };
                    productCollection.InsertOne(p);
                }
                else
                {
                    var result = productCollection.UpdateOne(Builders<Product>.Filter.Eq("name", name), Builders<Product>.Update.Set("price", 400).Set("quantity", 400));
                    Console.WriteLine("Guncellendi", result);

                }

              
            }

          
        }


        public void Delete(string adi,int price)
        {
            if (!string.IsNullOrEmpty(adi))
            {
                var product = productCollection.AsQueryable<Product>().SingleOrDefault(x => x.Name ==adi &&x.Price==price);
                if (product!=null)
                {
                    var result = productCollection.DeleteOne(Builders<Product>.Filter.Eq("name",product.Name));
                    Console.WriteLine("silindi", result.DeletedCount);
                }               
            }
        }



        public void DeleteTekli(string adi)
        {
            if (!string.IsNullOrEmpty(adi))
            {
                var product = productCollection.AsQueryable<Product>().SingleOrDefault(x => x.Name == adi);
                if (product != null)
                {
                    var result = productCollection.DeleteOne(Builders<Product>.Filter.Eq("name", product.Name));
                    Console.WriteLine("silindi", result.DeletedCount);
                }
            }
        }



    }
}
