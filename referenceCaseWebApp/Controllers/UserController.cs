using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using referenceCaseWebApp.DAL.Models;
using referenceCaseWebApp.Model;
using referenceCaseWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace referenceCaseWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository { get; set; }
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    User user = userRepository.GetUser();
        //    return Ok(user);
        //}

        [HttpGet]
        public async Task<IActionResult> GetUserAndEmloyee()
        {
            User user = userRepository.GetUserandEmployee();
            return Ok(user);
        }
    }
}
