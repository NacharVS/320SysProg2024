using MongoDatabase;

CRUD.CreateUser(new User("Fedot", 55, "udaloymolodec@mail.ru", "dksdjds"));

Team team = new Team();
User user = new User("Fedor", 55);

team.TeamList.Add(user);
CRUD.CreateTestTeam(team);