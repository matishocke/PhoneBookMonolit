using Newtonsoft.Json;
using RestSharp;

namespace PhoneBookMonolit.Services
{
    public class PhoneBookSearchService
    {
        public List<Models.PhoneBookEntry> SearchForEntry(string searchTerm)
        {
            List<Models.PhoneBookEntry> result = new List<Models.PhoneBookEntry>();

            var options = new RestClientOptions("https://localhost:7195/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("api/Entry/GetAllEntries", Method.Get);
            RestResponse response = client.Execute(request);
            var allEntries = JsonConvert.DeserializeObject<List<Models.PhoneBookEntry>>(response.Content);
           
            foreach (var entry in allEntries)
            {
                if (entry.FirstName.ToLower().Contains(searchTerm.ToLower()))
                {
                    result.Add(entry);
                }
                else if (entry.LastName.ToLower().Contains(searchTerm.ToLower()))
                {
                    result.Add(entry);
                }
                else if (entry.PhoneNumber.ToLower().Contains(searchTerm.ToLower()))
                {
                    result.Add(entry);
                }
            }
            return result;
        }
    }
}
