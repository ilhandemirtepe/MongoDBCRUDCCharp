using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public class Product
    {
        [BsonId]
        public ObjectId Id
        {
            get;
            set;
        }
        [BsonElement("name")]
        public string Name
        {
            get;
            set;
        }
        [BsonElement("price")]
        public double Price
        {
            get;
            set;
        }
        [BsonElement("quantity")]
        public double Quantity
        {
            get;
            set;
        }
        [BsonElement("status")]
        public bool Status
        {
            get;
            set;
        }
        [BsonElement("date")]
        public DateTime Date
        {
            get;
            set;
        }
    }
}
