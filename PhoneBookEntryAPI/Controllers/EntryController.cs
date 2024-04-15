using Microsoft.AspNetCore.Mvc;
using PhoneBookMonolit.Models;
using PhoneBookMonolit.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneBookEntryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private readonly EntryService _entryService;

        public EntryController(EntryService entryService)
        {
            _entryService = entryService;
        }

        // GET: api/<EntryController>
        [HttpGet]
        [Route ("GetAllEntries")]
        public List<PhoneBookEntry> GetAll()
        {
            return _entryService.GetAllEntries();
        }

        // GET api/<EntryController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var result = _entryService.GetAllEntries().FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        // POST api/<EntryController>
        [HttpPost]
        public void CreateEntry(string firstName, string lastName, string Phonenumber)
        {
            _entryService.CreateEntry(firstName, lastName, Phonenumber);
        }

        //// PUT api/<EntryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<EntryController>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteEntry(int id)
        {
            if (_entryService.DeleteEntry(id) == true) { return Ok(); }
            else { return NotFound(); }
        }
    }
}
