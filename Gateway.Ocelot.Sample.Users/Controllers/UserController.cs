

using Gateway.Ocelot.Sample.Users.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.Ocelot.Sample.Users.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) =>
            (_userRepository) = (userRepository);


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userRepository.Get(id);
            if(user is null) 
                return NotFound();

            return Ok(user);
        }
    }
}
