public class User
{   
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string userName { get; set; }
    public string password { get; set; }
    public  bool isLooggedIn;

    public void Login()
    {
        if (password==userName)
        {
            System.Console.WriteLine("User logged in successfully");
        }
        isLooggedIn = true;
    }

    public void Logout()
    {
        isLooggedIn = false;
    }

    public string GetFullInfo()
    {
        return $"{firstName} {lastName} {isLooggedIn}";
    }
}