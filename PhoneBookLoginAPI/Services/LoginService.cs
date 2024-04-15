namespace PhoneBookMonolit.Services
{
    public class LoginService
    {
        public bool Login(string username, string password)
        {
            if (username == "admin" &&  password == "pass") 
            {
                return true;
            }
            return false;
        }
    }
}
