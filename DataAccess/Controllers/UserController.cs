using System;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using Domain.Data;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _data;

        public UserController([FromServices] IUserRepo data)
        {
            _data = data;
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<ActionResult<User>> GetUser([FromRoute] int userId)
        {
            try
            {
                User user = _data.GetUser(userId);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser([FromBody] User user)

        {
            try
            {
                _data.UpdateUser(user);

                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}