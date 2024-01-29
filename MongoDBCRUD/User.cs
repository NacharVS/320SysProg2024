using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBCRUD
{
    public class User
    {
        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }

        //[BsonIgnore]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
