using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public class MyContext
    {

        public  static MongoClient mongoClient;
        public  static IMongoDatabase database;
        public static void MyContext1(  )
        {
            mongoClient = new MongoClient("mongodb://localhost:27017");
            database = mongoClient.GetDatabase("mydemo");
         
        }


      

    }
}
