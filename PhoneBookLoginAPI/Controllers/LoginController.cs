using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookMonolit.Services;

namespace PhoneBookLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        // POST api/<EntryController>
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
           if (_loginService.Login(username, password) == true) { return Ok(); }
           else { return NotFound(); }
        }
    }
}
