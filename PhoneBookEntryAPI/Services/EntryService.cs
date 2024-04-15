using Microsoft.AspNetCore.Http.HttpResults;

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
            Models.PhoneBookEntry entry = new Models.PhoneBookEntry();
            entry.FirstName = firstName;
            entry.LastName = lastName;
            entry.PhoneNumber = Phonenumber;

            if (_entries != null) { entry.Id = _entries.Count() + 1; }
            else { entry.Id = 1; }
            _entries.Add(entry);
        }

        public bool DeleteEntry(int id) 
        { 
            var entry = GetAllEntries().FirstOrDefault(x => x.Id == id);
            if (entry != null)
            {
                _entries.Remove(_entries.First(x => x.Id == id));
                return true;
                
            }
            return false;
           
        }
        public List<Models.PhoneBookEntry> GetAllEntries() 
        {
            return _entries;
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
