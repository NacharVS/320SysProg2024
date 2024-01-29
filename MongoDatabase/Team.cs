using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDatabase
{
    internal class Team
    {
        public Team()
        {
            TeamName = "TestTeam";
            //TeamList = CreateUsers();
        }

        public string TeamName { get; set; }
        public List<User> TeamList;


        /*static List<User> CreateUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User("Vovan", 44));
            return users;
        }*/
    }
}
