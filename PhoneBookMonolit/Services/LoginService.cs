using RestSharp;

namespace PhoneBookMonolit.Services
{
    public class LoginService
    {
        public bool Login(string username, string password)
        {
            var options = new RestClientOptions("https://localhost:7234/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("api/Login?username=admin&password=pass", Method.Post);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return true;
        }
    }
}
