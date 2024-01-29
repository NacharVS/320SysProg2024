using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDatabase
{
    internal class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public User(string name, int age, string email, string organization) : this(name, age)
        {
            Email = email;
            Organization = organization;
        }
        [BsonIgnore]
        public ObjectId _id;
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        [BsonIgnoreIfDefault]
        public string Organization { get; set; }
    }
}