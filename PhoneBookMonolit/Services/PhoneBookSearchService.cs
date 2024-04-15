namespace PhoneBookMonolit.Services
{
    public class PhoneBookSearchService
    {
        public List<Models.PhoneBookEntry> SearchForEntry(string searchTerm)
        {
            List<Models.PhoneBookEntry> result = new List<Models.PhoneBookEntry>();
            EntryService entryService = new EntryService();
            var allEntries = entryService.GetAllEntries();
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
