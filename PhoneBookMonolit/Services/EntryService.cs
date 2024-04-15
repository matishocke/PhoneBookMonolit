using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;

namespace PhoneBookMonolit.Services
{
    public class EntryService
    {
        private static List<Models.PhoneBookEntry> _entries;
        public EntryService()
        {
            if (_entries == null)
            {
                _entries = new List<Models.PhoneBookEntry>();
                CreateDummyEntries();
            }
        }
        public void CreateEntry(string firstName, string lastName, string Phonenumber)
        {
            var options = new RestClientOptions("https://localhost:7195/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("api/Entry", Method.Post);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void DeleteEntry(int id)
        {
            var options = new RestClientOptions("https://localhost:7195/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("api/Entry", Method.Delete);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public List<Models.PhoneBookEntry> GetAllEntries()
        {
            var options = new RestClientOptions("https://localhost:7195/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("api/Entry/GetAllEntries", Method.Get);
            RestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<List<Models.PhoneBookEntry>>(response.Content);
        }

        private void CreateDummyEntries()
        {
            _entries.Clear();
            _entries.Add(new Models.PhoneBookEntry { Id = 1, FirstName = "Lasse", LastName = "Rasch", PhoneNumber = "123456789" });
            _entries.Add(new Models.PhoneBookEntry { Id = 2, FirstName = "Børge", LastName = "Hansen", PhoneNumber = "60000012" });
            _entries.Add(new Models.PhoneBookEntry { Id = 3, FirstName = "Hanne", LastName = "Rasmussen", PhoneNumber = "11223366" });
            _entries.Add(new Models.PhoneBookEntry { Id = 4, FirstName = "Hanne", LastName = "Madsen", PhoneNumber = "70265599" });
            _entries.Add(new Models.PhoneBookEntry { Id = 5, FirstName = "Lone", LastName = "Madsen", PhoneNumber = "40995579" });
            _entries.Add(new Models.PhoneBookEntry { Id = 6, FirstName = "Henrik", LastName = "Rasmussen", PhoneNumber = "66554479" });
        }
    }
}
