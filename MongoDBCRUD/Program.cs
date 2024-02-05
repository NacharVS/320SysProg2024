using MongoDBCRUD;

var newUser = new User("Elvina", "Shamil@insaf.com", 13);
var oldUser = CRUD.GetUser("Elvina");
CRUD.EditUser(oldUser, newUser);
var list = new List<User>();
list.Add(oldUser);
var team = new Team("Ляляля", list);
CRUD.CreateTeam(team);

