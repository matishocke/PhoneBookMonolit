using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookMonolit.Services;
using System.Reflection;

namespace PhoneBookSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookSearchController : ControllerBase
    {
        private readonly PhoneBookSearchService _phoneBookSearchService;

        public PhoneBookSearchController(PhoneBookSearchService phoneBookSearchService)
        {
            _phoneBookSearchService = phoneBookSearchService;
        }


        // POST api/<EntryController>
        [HttpGet]
        public ActionResult SearchForEntry(string searchTerm)
        {
            var result = _phoneBookSearchService.SearchForEntry(searchTerm);
            if (result != null) { return Ok(result); }
            else { return NotFound(); }
        }
    }
}
