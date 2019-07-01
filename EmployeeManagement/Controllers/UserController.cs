using EmployeeManagement.Models;
using EmployeeManagement.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Route("api/user")]
    [ApiController]

    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("{id}")]

        public ActionResult<UserDto> Get([FromRoute]int id)
        {
            User model = _userRepository.GetUser(id);
            if (model != null)
            {
                return new UserDto
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Address = model.Address,

                };
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("list")]
        public ActionResult<IEnumerable<UserDto>> GetAll()
        {
            var model = _userRepository.GetUsersList();
            if (model != null)
            {
                return Json(model);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost("")]
        public ActionResult<UserDto> Create([FromBody]UserDto req)
        {
            if (req == null)
            {
                return BadRequest();
            }

            User newUser = new User
            {
                FirstName = req.FirstName,
                LastName = req.LastName,
                Email = req.Email,
                Address = req.Address
            };
            _userRepository.Add(newUser);
            return Ok();
        }

        //public string Index()
        //{
        //    return _userRepository.GetUser(1).Name;
        //}
    }
}
