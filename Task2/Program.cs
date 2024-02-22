var user1 = new User();
user1.firstName = "Abdullo ";
user1.lastName = "Abdulloev";
user1.userName = "Abdu";
user1.password = "Abduev";
user1.Login();
System.Console.WriteLine(user1.GetFullInfo());

user1.Logout();
