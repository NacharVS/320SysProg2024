using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBCRUD
{
    internal class CRUD
    {
        public static string connectionString = "mongodb://localhost";
        public static void CreateUser(User user)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CRUD");
            var collection = database.GetCollection<User>("UserCollection");
            collection.InsertOne(user);
        }

        public static void CreateTeam(Team team)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CRUD");
            var collection = database.GetCollection<Team>("TeamCollections");
            collection.InsertOne(team);
        }
        public static User GetUser(string name)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CRUD");
            var collection = database.GetCollection<User>("UserCollection");
            var user = collection.Find(x => x.Name == name).FirstOrDefault();
            if (user != null)
                return user;
            else
                return null;
        }
        public static void EditUser(User oldUser, User newUser)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("CRUD");
            var collection = database.GetCollection<User>("UserCollection");
            var filter = new BsonDocument("Name", $"{oldUser.Name}");
            var updateSettings = new BsonDocument("$set", new BsonDocument { { "Name", $"{newUser.Name}" }, { "Email", $"{newUser.Email}" }, { "Age", newUser.Age } });
            var result = collection.UpdateOne(filter, updateSettings);

        }
    }
}
