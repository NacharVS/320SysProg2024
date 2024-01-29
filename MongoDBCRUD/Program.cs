using MongoDBCRUD;

var newUser = new User("Elvina", "Shamil@insaf.com", 13);
var oldUser = CRUD.GetUser("Elvina");
CRUD.EditUser(oldUser, newUser);

