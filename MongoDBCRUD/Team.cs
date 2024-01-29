using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBCRUD
{
    public class Team
    {
        public Team( string name, List<User> users)
        {
            TeamName = name;
            TeamList = users;
        }

        public string TeamName { get; set; }
        public List<User> TeamList;

        //static List<User> CreateUsers()
        //{
        //    List<User> users = new List<User>();
        //    users.Add(new User("Arseniy", "dssd", 44));
        //    users.Add(new User("Elvina", "dssd", 44));
        //    return users;
        //}
    }
}
